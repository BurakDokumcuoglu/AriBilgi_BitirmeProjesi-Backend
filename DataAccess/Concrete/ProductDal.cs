using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DataAccess.Concrete
{
    public class ProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            using (OyunPazariContext context = new OyunPazariContext())
            {
                 var result = context.Set<Product>().ToList();
                 return result;               
            }
        }
    }
}
