using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Menu
    {
        private String foodName;
        private String foodPrice;
        private int quantity;
        private String totalPrice;

        public Menu()
        {
        }

        public Menu(string foodName, string foodPrice, int quantity, string totalPrice)
        {
            this.foodName = foodName;
            this.foodPrice = foodPrice;
            this.quantity = quantity;
            this.totalPrice = totalPrice;
        }

        public string FoodName { get => foodName; set => foodName = value; }
        public string FoodPrice { get => foodPrice; set => foodPrice = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
