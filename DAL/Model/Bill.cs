using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Bill
    {
        private int id;
        private int tableId;
        private String checkIn;
        private String checkOut;
        private int status;

        public Bill()
        {
        }

        public Bill(int id, int tableId, string checkIn, string checkOut, int status)
        {
            this.id = id;
            this.tableId = tableId;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.status = status;
        }

        public int Id { get => id; set => id = value; }
        public int TableId { get => tableId; set => tableId = value; }
        public string CheckIn { get => checkIn; set => checkIn = value; }
        public string CheckOut { get => checkOut; set => checkOut = value; }
        public int Status { get => status; set => status = value; }
    }
}
