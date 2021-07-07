using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormHW2
{
    public partial class Exercise1_2 : Form
    {
        public Exercise1_2()
        {
            InitializeComponent();
        }
        public void AddFile(string file)
        {

            listBox1.Items.Add(file);

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
            listBox1.Items.Clear();
        }
    }
}
