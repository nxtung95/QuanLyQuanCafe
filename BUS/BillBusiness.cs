using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BillBusiness
    {
        private BillDao billDao;

        public BillBusiness()
        {
            billDao = new BillDao();
        }

        public List<Menu> getAllMenuByTableId(int tableId)
        {
            return billDao.getMenuByTableId(tableId);
        }

        public bool handleAddFood(Food foodSelected, Table currentTable, int soLuong)
        {
            if (currentTable.Status == 0)
            {
                Bill bill = new Bill();
                bill.TableId = currentTable.Id;
                bill.CheckIn = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                bill.CheckOut = "";
                bill.Status = 0;
                return billDao.addBillWithoutActiveTable(foodSelected.Id, bill, soLuong);
            } else
            {
                Bill bill = billDao.getBillByTableId(currentTable.Id);
                BillDetail billDetail = billDao.checkExistFoodBillDetail(bill.Id, foodSelected.Id);
                if (billDetail != null && billDetail.Quantity > 0)
                {
                    int newQuantity = billDetail.Quantity + soLuong;
                    return billDao.updateBillDetail(bill.Id, foodSelected.Id, newQuantity);
                } else
                {
                    return billDao.insertBillDetail(bill.Id, foodSelected.Id, soLuong);
                }
                return true;
            }
        }
    }
}
