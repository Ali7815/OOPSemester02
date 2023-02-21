using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costumer_Product.Bl
{
    class Product
    {
        public string PName;
        public string PCategory;
        public int price;
        public Product(string PName,string PCategory,int price)
        {
            this.PName = PName;
            this.PCategory = PCategory;
            this.price = price;
        }
        public float calculateTax()
        {
            float tax;
            if(PCategory=="Fruits")
            {
                tax = price - 10;
            }
            else if (PCategory == "Grocery")
            {
                tax = price - 20;
            }
            else
            {
                tax = price - 30;
            }
            return tax;
        }
    }
}
