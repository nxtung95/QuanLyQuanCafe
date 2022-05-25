using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CategoryBusiness
    {
        private CategoryDao categoryDao;

        public CategoryBusiness()
        {
            categoryDao = new CategoryDao();
        }
        public List<Category> getAllCategory()
        {
            return categoryDao.getAllCategory();
        }
    }
}
