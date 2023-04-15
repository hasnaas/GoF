using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class Stock : Subject
    {
        public string Name { get; set; }
        private int price;
        public int Price
        {
            get { return price; }
            set
            {
                price = value;
                NotifyObservers(new { name = Name, price=price }) ;
            }
        }

        public Stock(string name, int p)
        {
            Name = name;
            price = p;
        }
        public override string ToString()
        {
            return Name + " : " + price;
        }
    }
}
