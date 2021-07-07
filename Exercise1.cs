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

namespace WinFormHW2
{
    public partial class Exercise1 : Form
    {
        string s;
        Exercise1_2 exercise ;
        public Exercise1()
        {
            InitializeComponent();
           
            exercise = new Exercise1_2();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {

              s=  folderBrowser.SelectedPath;
            }
           
         
        }

        private void Search_Click(object sender, EventArgs e)
        {
            DirectoryInfo directory = new DirectoryInfo(s);
            if (Extension.Text.ToString() != string.Empty)
            {
                foreach (var item in directory.GetFiles(Extension.Text))
                {
                    exercise.AddFile(item.Name);
                }

              
                exercise.ShowDialog();
            }
            else {
                MessageBox.Show("Extension is empty","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
