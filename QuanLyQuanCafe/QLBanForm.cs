using BUS;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = DAL.Model.Menu;

namespace QuanLyQuanCafe
{
    public partial class QLBanForm : Form
    {
        private TableBusiness tableBusiness;
        private CategoryBusiness categoryBusiness;
        private FoodBusiness foodBusiness;
        private BillBusiness billBusiness;

        public QLBanForm()
        {
            InitializeComponent();
            categoryBusiness = new CategoryBusiness();
            foodBusiness = new FoodBusiness();
            tableBusiness = new TableBusiness();
            billBusiness = new BillBusiness();
        }

        private void QLBanForm_Load(object sender, EventArgs e)
        {
            loadAllTable();
            loadAllCategory();
        }

        private void loadAllCategory()
        {
            List<Category> categories = categoryBusiness.getAllCategory();
            cbLoaiDoUong.DataSource = categories;
            cbLoaiDoUong.DisplayMember = "Name";
        }

        private void loadAllFoodByCategoryId(int categoryId)
        {
            List<Food> foodList = foodBusiness.findAllFoodByCategoryId(categoryId);
            cbDoUong.DataSource = foodList;
            cbDoUong.DisplayMember = "Name";
        }

        private void loadAllTable()
        {
            flowLayoutPanel1.Controls.Clear();

            List<Table> tableList = tableBusiness.getAllTable();
            foreach (Table table in tableList)
            {
                Button btnTable = new Button();
                btnTable.Width = 100;
                btnTable.Height = 100;
                btnTable.Click += BtnTable_Click;
                btnTable.Text = table.Name;
                btnTable.Tag = table;
                if (table.Status == 1)
                {
                    btnTable.BackColor = Color.Brown;
                }
                flowLayoutPanel1.Controls.Add(btnTable);
            }
        }

        private void showBill(int tableId)
        {
            List<Menu> menuList = billBusiness.getAllMenuByTableId(tableId);
            foreach (Menu menu in menuList)
            {
                ListViewItem lsvItem = new ListViewItem(menu.FoodName);
                lsvItem.SubItems.Add(menu.FoodPrice);
                lsvItem.SubItems.Add(menu.Quantity.ToString());
                lsvItem.SubItems.Add(menu.TotalPrice);

                lvMenu.Items.Add(lsvItem);
            }
        }

        private void BtnTable_Click(object sender, EventArgs e)
        {
            lvMenu.Items.Clear();
            Table table = (sender as Button).Tag as Table;
            btnThemDoUong.Tag = table;
            if (table.Status == 0)
            {
                return;
            }
            int tableId = table.Id;
            showBill(tableId);
        }

        private void cbLoaiDoUong_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }
            Category selectedCategory = cb.SelectedItem as Category;
            id = selectedCategory.Id;

            loadAllFoodByCategoryId(id);
        }

        private void btnThemDoUong_Click(object sender, EventArgs e)
        {
            Table currentTable = (sender as Button).Tag as Table;
            Food foodSelected = cbDoUong.SelectedItem as Food;
            int soLuong = (int) numSoLuong.Value;
            bool result = billBusiness.handleAddFood(foodSelected, currentTable, soLuong);
            if (!result)
            {
                MessageBox.Show("Có lỗi xảy ra");
                return;
            }
            loadAllTable();

            String foodName = foodSelected.Name;
            String price = foodSelected.Price;
            String totalPrice = Convert.ToString(Convert.ToDouble(price) * soLuong);
            ListViewItem listViewItem = new ListViewItem(foodName);
            listViewItem.SubItems.Add(price);
            listViewItem.SubItems.Add(soLuong.ToString());
            listViewItem.SubItems.Add(totalPrice);
            lvMenu.Items.Add(listViewItem);
        }
    }
}
