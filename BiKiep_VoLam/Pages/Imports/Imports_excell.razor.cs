using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DTO;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Extensions.Logging;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using OfficeOpenXml;



namespace BiKiep_VoLam.Pages.Imports
{
    public partial class Imports_excell
    {
        DataTable dt = new DataTable();
        List<dto_excell_imports> lst = new List<dto_excell_imports>();
        private List<IBrowserFile> loadedFiles = new();
        private long maxFileSize = 1024 * 15;
        private int maxAllowedFiles = 3;
        private bool isLoading;




   


        public async Task ImportFile( InputFileChangeEventArgs e)
        {


            var fileStream = e.File.OpenReadStream();
            var ms = new MemoryStream();
            await fileStream.CopyToAsync(ms);
            fileStream.Close();
            ms.Position = 0;
            ISheet sheet;
            var xsswb = new XSSFWorkbook(ms);

            sheet = xsswb.GetSheetAt(0);
            IRow hr = sheet.GetRow(0);
            var rl = new List<string>();

            int cc = hr.LastCellNum;
            for(int j=0;j<cc;j++)
            {
                ICell cell = hr.GetCell(j);
                string _data = "";
                if(cell!=null)
                {
                    _data = cell.ToString();
                }
                
                dt.Columns.Add(_data);
            } 
            for(var j =(sheet.FirstRowNum + 1); j <sheet.LastRowNum;j++)
            {

                var r = sheet.GetRow(j);
                for(var  i  = r.FirstCellNum;i< cc;i++)
                {
                    if(r.GetCell(i)==null)
                    {
                        rl.Add("");
                    }
                    else
                    {
                        rl.Add(r.GetCell(i).ToString());
                    }
                    
                }    
                if(rl.Count > 0 )
                {
                    dt.Rows.Add(rl.ToArray());
                }
                rl.Clear();
            }    

        }


        public void excell_reader()
        {

            string file_path = @"E:\Layout_DNSPro.xlsx";

            FileInfo exfile = new FileInfo(file_path);


            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage packed = new ExcelPackage(exfile))
            {
                ExcelWorksheet worksheet = packed.Workbook.Worksheets.FirstOrDefault();
                int colCount = worksheet.Dimension.End.Column;
                int rowCount = worksheet.Dimension.End.Row;
                for (int row = 1; row <= rowCount; row++)
                {
                    dto_excell_imports _data = new dto_excell_imports();
                    for (int col = 1; col < colCount; col++)
                    {
                        if (col == 1)
                            _data.col_01 = worksheet.Cells[row, col].Value == null ? "" : worksheet.Cells[row, col].Value.ToString();
                        else if (col == 2)
                            _data.col_02 = worksheet.Cells[row, col].Value == null ? "" : worksheet.Cells[row, col].Value.ToString();
                        else if (col == 3)
                            _data.col_03 = worksheet.Cells[row, col].Value == null ? "" : worksheet.Cells[row, col].Value.ToString();
                    }
                    lst.Add(_data);
                }

            }
             


            DTO_DLL.Class1 _bd = new DTO_DLL.Class1();
            _bd.getdata();


        }

       


        private async Task LoadFiles(InputFileChangeEventArgs e)
        {
            isLoading = true;
            loadedFiles.Clear();

            foreach (var file in e.GetMultipleFiles(maxAllowedFiles))
            {
                try
                {
                    loadedFiles.Add(file);

                    var trustedFileNameForFileStorage = Path.GetRandomFileName();
                    var path = Path.Combine(Environment.ContentRootPath,
                            Environment.EnvironmentName, "unsafe_uploads",
                            trustedFileNameForFileStorage);

                    await using FileStream fs = new(path, FileMode.Create);
                    await file.OpenReadStream(maxFileSize).CopyToAsync(fs);
                }
                catch (Exception ex)
                {
                    Logger.LogError("File: {Filename} Error: {Error}",
                        file.Name, ex.Message);
                }
            }

            isLoading = false;
        }

    }
}
