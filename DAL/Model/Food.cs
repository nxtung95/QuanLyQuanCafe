using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Food
    {
        private int id;
        private int categoryId;
        private String name;
        private String price;

        public Food()
        {
        }

        public Food(int id, int categoryId, string name, string price)
        {
            this.id = id;
            this.categoryId = categoryId;
            this.name = name;
            this.price = price;
        }

        public int Id { get => id; set => id = value; }
        public int CategoryId { get => categoryId; set => categoryId = value; }
        public string Name { get => name; set => name = value; }
        public string Price { get => price; set => price = value; }
    }
}
