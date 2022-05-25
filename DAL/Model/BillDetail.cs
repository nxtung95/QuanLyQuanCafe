using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class BillDetail
    {
        private int billId;
        private int foođId;
        private int quantity;

        public BillDetail()
        {
        }

        public BillDetail(int billId, int foođId, int quantity)
        {
            this.billId = billId;
            this.foođId = foođId;
            this.quantity = quantity;
        }

        public int BillId { get => billId; set => billId = value; }
        public int FoođId { get => foođId; set => foođId = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
