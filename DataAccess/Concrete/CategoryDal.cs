using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        public List<Category> GetAll()
        {
            using (OyunPazariContext context = new OyunPazariContext())
            {
                var result = context.Set<Category>().ToList();
                return result;
            }
        }
    }
}
