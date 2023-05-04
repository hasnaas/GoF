using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public class Product
    {
        public int Id { get; }
        public string Name { get; set; }

        public Product(int id,string name)
        {
            Id = id;
            Name = name;
        }


      
    }
}
