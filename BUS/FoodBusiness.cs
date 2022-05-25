using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class FoodBusiness
    {
        private FoodDao foodDao;
        public FoodBusiness()
        {
            foodDao = new FoodDao();
        }

        public List<Food> findAllFoodByCategoryId(int categoryId)
        {
            return foodDao.findAllFoodByCategoryId(categoryId);
        }
    }
}
