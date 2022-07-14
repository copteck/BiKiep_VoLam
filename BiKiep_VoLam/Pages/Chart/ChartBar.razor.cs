using System.Collections.Generic;

namespace BiKiep_VoLam.Pages.Chart
{
    public partial class ChartBar
    {



        public List<chart_demo> lst_demo { get; set; } = new List<chart_demo>();


        public class chart_demo
        {
            public string name { get; set; }
            public double value { get; set; }
        }


        protected override void OnInitialized()
        {

            lst_demo = new List<chart_demo>();
            lst_demo.Add(new chart_demo
            {
                name = "Phải thu",
                value = 30000000000
            });

            lst_demo.Add(new chart_demo
            {
                name = "Phải trả",
                value = 20000000000
            });


            lst_demo.Add(new chart_demo
            {
                name = "Công nợ",
                value = 10000000000
            });
        }



    }
}
