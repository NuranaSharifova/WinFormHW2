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
    public partial class Exercise3_2 : Form
    {
        Exercise3 Exercise3 ;
        public Exercise3_2(Exercise3 exercise3)
        {
            InitializeComponent();
            Exercise3 = exercise3;
            Editbox.Text = Exercise3.tempName;

        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(Exercise3.openFileDialog.FileName);
            sw.Write(Editbox.Text);
            sw.Close();
            Exercise3.Filename.Text = Editbox.Text;
            Close();
          
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Exercise3.ShowDialog();
           
        }
    }
}
