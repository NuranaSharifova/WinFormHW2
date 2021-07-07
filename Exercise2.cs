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
    public partial class Exercise2 : Form
    {
        public Products Chosenproduct { get; set; }
        double sum = 0;
        public List<Products> products { get; set; }
        public Exercise2()
        {
            InitializeComponent();
         
        products = new List<Products>  {
             new Products("Asus VivoBook","16 RAM,512 Gb SSD,i7","Fast processor",2000),
             new Products("HP Pavilion","8 RAM,512 Gb SSD,i5","Middle speed",1500),
             new Products("Acer","8 RAM,256 Gb SSD,i3","Not so fast",1000 )
            };

            foreach (Products product in products)
            {
                Productlist.Items.Add(product.Name);
            }
            Price.Text = null;
        }

        private void Add_Click(object sender, EventArgs e)
        {
           
            Exercise2_2 Exercise2_2 = new Exercise2_2(this);
            Productlist.Items.Remove(Productlist.SelectedItem);
            Exercise2_2.ShowDialog();
            listBox1.Items.Add(Chosenproduct.Name);
            sum += Chosenproduct.Price;
        }

        private void Productlist_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (Products product  in products)
            {

                if (product.Name ==Productlist.Text) {

                   Price.Text = product.Price.ToString()  ;
                    Chosenproduct = product;
                }

            }
           

        }

        private void Totalbutton_Click(object sender, EventArgs e)
        {

          
            MessageBox.Show($"Total price is {sum}");
        }
    }
}
