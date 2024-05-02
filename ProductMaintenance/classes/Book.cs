using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMaintenance.classes
{
    public class Book: Product
    {
        private string author;

        public Book() { }

        //Create Construtor extend inheriend from base class.
        public Book(string code, string description, string author, decimal price)
            : base(code, description, price)
        {
            this.Author = author;
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
      
        public override string GetDisplayText(string sep)
        {
            return base.GetDisplayText(sep) + " (" + Author + ")";
        }

    }
}
