using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public class DbContext
    {
        private Dictionary<int, Product> updatedObjects = new Dictionary<int, Product>();

        public ProductProxy getProduct(int id)
        {
            // Automatically generate SQL statements
            // to read the product with the given ID.
            Console.WriteLine("SELECT * FROM products WHERE product_id = "+id);

            // Simulate reading a product object from a database.
            var product = new Product(id,"Produc1");
            
            return new ProductProxy(this,product.Id,product.Name);
        }

        public void saveChanges()
        {
            // Automatically generate SQL statements
            // to update the database.
            foreach (var updatedObject in updatedObjects)
                Console.WriteLine($"UPDATE products SET name = {updatedObject.Value.Name} WHERE product_id = {updatedObject.Value.Id}");

            updatedObjects.Clear();
        }

        public void markAsChanged(Product product)
        {
            updatedObjects.Add(product.Id, product);
        }
    }
}
