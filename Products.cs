using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormHW2
{
    public class Products
    {
        public Products(string name, string properties, string description, double price)
        {
            Name = name;
            Properties = properties;
            Description = description;
            Price = price;
           
        }

        public string Name { get; set; }
        public string Properties { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
       
        public Products()
        {
                
        }
        public override string ToString()
        {
            return $"Properties {Properties}, Description {Description}"; 
        }
    }


}
