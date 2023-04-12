using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator
{
    public class ProductCollection
    {
        private List<Product> Products = new List<Product>();

        public void Add(Product product)
        {
            Products.Add(product);
        }

        public IMyIterator<Product> GetIterator()
        {
            return new ListIterator(this);
        }


        public class ListIterator : IMyIterator<Product>
        {
            private ProductCollection _productCollection;
            private int Index;

            public ListIterator(ProductCollection pc)
            {
                _productCollection = pc;
            }
            public  bool HasNext()
            {
                return Index < _productCollection.Products.Count();
            }

            public Product Next()
            {
                var p=_productCollection.Products[Index];
                Index++;
                return p;
            }
        }
    }
}
