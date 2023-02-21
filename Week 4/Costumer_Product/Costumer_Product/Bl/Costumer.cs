using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costumer_Product.Bl
{
    class Costumer
    {
        public string Name;
        public string Address;
        public string Number;
        List<Product> products = new List<Product>();
        public Costumer(string Name,string Address,string Number)
        {
            this.Name = Name;
            this.Address = Address;
            this.Number = Number;
        }
        public List<Product> getallProducts()
        {
            return products;
        }
        public void addproduct(Product P)
        {
            products.Add(P);
        }

    }
}
