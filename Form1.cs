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
    public partial class Form1 : Form
    {

        Exercise1 exercise1 = new Exercise1();
        Exercise2 exercise2 = new Exercise2();
        Exercise3 exercise3 = new Exercise3();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exercise1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            exercise2.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            exercise3.ShowDialog();
        }
    }
}
