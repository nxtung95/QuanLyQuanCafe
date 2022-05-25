using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Table
    {
        private int id;
        private String name;
        private int status;

        public Table()
        {
        }

        public Table(int id, string name, int status)
        {
            this.Id = id;
            this.name = name;
            this.status = status;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Status { get => status; set => status = value; }
    }
}
