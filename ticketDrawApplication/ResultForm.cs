using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace biletCekilisUygulaması
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTxtSave_Click(object sender, EventArgs e)
        {
            Write_Text(richTextBox1.Text);
        }

        void Write_Text(string text)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.CreatePrompt = false; //create if no file
            save.OverwritePrompt = true; //overwrite if file exists
            save.Title = "Save the Results";
            save.DefaultExt = "rtf";
            save.Filter = "Rich Text Document File (*.rtf)|*.rtf|All Files(*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(save.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                fs.Close();
                File.AppendAllText(save.FileName, Environment.NewLine + text);
            }
        }

        private void SonucForm_Load(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = 0;
        }

       
    }

}
