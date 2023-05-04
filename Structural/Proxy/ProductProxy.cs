using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public class ProductProxy:Product
    {
        private DbContext _dbContext;
        public new string Name
        {
            get
            {
                return base.Name;
            }
            set
            {
                base.Name = value;
                _dbContext.markAsChanged(this);
            }
        }
        public ProductProxy(DbContext context,int Id,string Name):base(Id,Name)
        {
            _dbContext = context;
            
        }





    }
}
