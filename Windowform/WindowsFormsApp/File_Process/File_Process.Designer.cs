namespace WindowsFormsApp.File_Process
{
	partial class File_Process
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txt_text = new DevExpress.XtraEditors.TextEdit();
            this.btn_chonfile_excell = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_text.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(72, 93);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(106, 44);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Chọn đường dẫn";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txt_text
            // 
            this.txt_text.Location = new System.Drawing.Point(72, 12);
            this.txt_text.Name = "txt_text";
            this.txt_text.Size = new System.Drawing.Size(407, 20);
            this.txt_text.TabIndex = 1;
            // 
            // btn_chonfile_excell
            // 
            this.btn_chonfile_excell.Location = new System.Drawing.Point(195, 93);
            this.btn_chonfile_excell.Name = "btn_chonfile_excell";
            this.btn_chonfile_excell.Size = new System.Drawing.Size(106, 44);
            this.btn_chonfile_excell.TabIndex = 2;
            this.btn_chonfile_excell.Text = "Đọc File Excell";
            // 
            // File_Process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_chonfile_excell);
            this.Controls.Add(this.txt_text);
            this.Controls.Add(this.simpleButton1);
            this.Name = "File_Process";
            this.Text = "File_Process";
            this.Load += new System.EventHandler(this.File_Process_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_text.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraEditors.TextEdit txt_text;
        private DevExpress.XtraEditors.SimpleButton btn_chonfile_excell;
    }
}