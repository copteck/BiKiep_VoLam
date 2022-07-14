using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace BiKiep_VoLam.Pages.RSS
{
    public partial class RSS_html_page
    {


        public class data_retuen
        {
            public List<thongtin_doanhnghiep> lst { get; set; }= new List<thongtin_doanhnghiep> ();
            public int count_page { get; set; } = 0;

        }


        public int stt { get; set; } = 0;

        public class thongtin_doanhnghiep
        {
            public string ten { get; set; }
            public string diachi { get; set; }
            public string mst { get; set; }
        }
        //[Inject]
        public List<thongtin_doanhnghiep> lst { get;set; } = new List<thongtin_doanhnghiep>();





    }
}
