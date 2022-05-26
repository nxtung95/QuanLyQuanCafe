using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TableBusiness
    {
        private TableDao tableDao;

        public TableBusiness()
        {
            this.tableDao = new TableDao();
        }

        public List<Table> getAllTable()
        {
            return tableDao.getAllTable();
        }

        public String getNextTableName()
        {
            return tableDao.getNextTableName();
        }

        public bool add(String name, int status)
        {   
            Table table = new Table();
            table.Name = name;
            table.Status = status;
            return tableDao.add(table);
        }

        public bool delete(int tableId)
        {
            return tableDao.delete(tableId);
        }
    }
}
