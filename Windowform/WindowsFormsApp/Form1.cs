 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel;
using Microsoft.Office;
 
 
namespace WindowsFormsApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
           
           

		}

        private void button2_Click(object sender, EventArgs e)
        {



            using (OpenFileDialog dialog = new OpenFileDialog()
            {

                Filter = "Excel Workbook|*.xls",
                ValidateNames = true



            })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    FileStream filestream =
                        File.Open(dialog.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader = ExcelReaderFactory.CreateBinaryReader(filestream);
                    var data111 = reader.AsDataSet();
                    DataTable data1 = new DataTable();
                    data1 = data111.Tables[1];
                    foreach(DataRow dr in data1.Rows)
                    {
                        chucpcdxcontext db = new chucpcdxcontext();
                        db.DM_TaiLieu.Add(new DM_TaiLieu { id = Guid.NewGuid(),
                            ma_tailieu = dr[0].ToString(), 
                            ngaytao=DateTime.Now,
                            ten_tailieu = dr[1].ToString(),
                            url = dr[2].ToString(),
                            ma_tailieu_cha = "VASS_VienDong",
                            ma_nhom_tailieu = "TaiLieu_DaoTaoPhiNhanTho",
                            daxoa =0,
                            khongsudung =0,
                            nguoitao = "chucpc" });
                        db.SaveChanges();


                    }
                }
            } 
        }
    }
}
