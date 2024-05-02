using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMaintenance.classes
{
    public class Product
    {
        public string Code;
        public string Description;
        public decimal Price;
 
        public Product() { }

        public Product(string code, string description, decimal price)
        
        {
            this.Code = code;
            this.Description = description;
            this.Price = price;
        }
        public virtual string GetDisplayText(string sep)
        {
            return Code + sep + Price.ToString("c") + sep + Description;
        }

        public string code
        {
            get { return code;}
            set { code = value; }
        }
        public string description
        {
            get { return description; }
            set { description = value; }
        }
        public decimal price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
