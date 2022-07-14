using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.File_Process
{
	public partial class File_Process : Form
	{
		public File_Process()
		{
			InitializeComponent();
		}

		private void File_Process_Load(object sender, EventArgs e)
		{


		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txt_text.Text = fbd.SelectedPath;
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                    var fileCount = (from file in Directory.EnumerateFiles(txt_text.Text, "*", SearchOption.AllDirectories)
                                     select file);

                    foreach(var  items in fileCount)
                    {
                        string ite = items;
                    }    

                }
            }

           
        }
	}
}
