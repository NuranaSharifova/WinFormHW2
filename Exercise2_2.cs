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
    public partial class Exercise2_2 : Form
    {
        Exercise2 exercise2 =null;




        public Exercise2_2(Exercise2 _exercise2)
        {
            InitializeComponent();
            exercise2 = _exercise2;
            Nametextbox.Text = exercise2.Chosenproduct.Name;
            Propertiestextbox.Text = exercise2.Chosenproduct.Properties;
            Descriptiontextbox.Text = exercise2.Chosenproduct.Description;
           
            
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            
           
            exercise2.Chosenproduct.Name = Nametextbox.Text;
            exercise2.Chosenproduct.Properties = Propertiestextbox.Text;
            exercise2.Chosenproduct.Description = Descriptiontextbox.Text;
            exercise2.products.Add(exercise2.Chosenproduct);
            exercise2.listBox1.Items.Add(exercise2.Chosenproduct.Properties + " " + exercise2.Chosenproduct.Description);
            this.Close();
        }

       

    
    }
}
