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
    public partial class Exercise3 : Form
    {
        public string tempName { get; set; }
     
        public OpenFileDialog openFileDialog { get; set; }
        public Exercise3()
        {
            InitializeComponent();
            Filename.ReadOnly = true;
        }

        private void Downloadbutton_Click(object sender, EventArgs e)
        {
             openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Txt files(*.txt) |*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Downloadbutton.Enabled = true;
                StreamReader streamReader = File.OpenText(openFileDialog.FileName);
                tempName = streamReader.ReadToEnd();
               
                Filename.Text = tempName;
                streamReader.Close();
               
            }
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            Exercise3_2 Exercise3_2 = new Exercise3_2(this);
            Filename.ReadOnly = false;
            Exercise3_2.Show();
        }

      
    }
}
