/*
 * Author - Raikhana Urazbaeva 
 * Form - To display and view selected products
 * June 2019
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_Project
{
    public partial class DisplayProducts : Form
    {
        public ProductClass z { get; set; }
        public int orderID;
        public DisplayProducts(int order_id)
        {
            orderID = order_id;
            InitializeComponent();
        }
        List<ProductClass> products = new List<ProductClass>();
        private void FillListViewOrders()
        {
                products = OrderDB_Class.GetProductByID(orderID);
                foreach (ProductClass product in products)
                {
                lstDisplayProduct.Columns[0].ListView.Font = new Font(lstDisplayProduct.Columns[0].ListView.Font, FontStyle.Bold);
                string[] row1 = {
                                    product.nameProduct,
                                    product.descriptionProduct,
                                    product.costProduct.ToString(),
                                    product.ammountProduct.ToString(),
                                };
                ListViewItem listUser = new ListViewItem(row1);
                listUser.Font = new Font(listUser.Font, FontStyle.Regular);
                lstDisplayProduct.Items.Add(listUser);
                }
        }

        private void DisplayProducts_Load(object sender, EventArgs e)
        {
            FillListViewOrders();
        }
    }
}
