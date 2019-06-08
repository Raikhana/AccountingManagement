/*
 * Author - Raikhana Urazbaeva 
 * Form - For user to add and delete a product in an order list
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
using System.Configuration;

namespace Example_Project
{
    public partial class AddOrder : Form
    {
        public OrderClass getOrder { get; set; }
        public List<Order_Products> getProducts { get; set; }
        public AddOrder()
        {
            InitializeComponent();
        }
        private void AddOrder_Load(object sender, EventArgs e)
        {
            FillComboBoxProductName();
            FillListViewAddedOrder();
        }

        List<ProductClass> products = new List<ProductClass>();
        List<ClientClass> clients = new List<ClientClass>();
        OrderClass order = new OrderClass();
        private void FillComboBoxProductName()
        {
            try
            {
                comboBoxOrderProduct.SelectedIndexChanged -= comboBoxOrderProduct_SelectedIndexChanged;

                clients = ClientDB_Class.GetClients();
                comboBoxOrderProduct.DataSource = clients;
                comboBoxOrderProduct.DisplayMember = "firstNameClient"; 
                comboBoxOrderProduct.ValueMember = "idClient";

                comboBoxOrderProduct.SelectedIndexChanged += comboBoxOrderProduct_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        
        private void comboBoxOrderProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            order.client_id = (int)comboBoxOrderProduct.SelectedValue;
           
        }  
        
        private void FillListViewAddedOrder()
        {
            lstAddedOrder.Items.Clear();
            List<ProductClass> products = new List<ProductClass>();
            products = ProductDB_Class.GetProducts();

            List<ProductStatusClass> statuses = new List<ProductStatusClass>();
            statuses = Product_statusDBClass.GetProduct_status();

            foreach (ProductClass product in products)
            {
                string statusName = "";
                int statusID = 0;
                foreach (ProductStatusClass status in statuses)
                {
                    if (product.idStatusProduct == status.id)
                    {
                        statusID = status.id;
                        statusName = status.status;
                    }
                }
                lstAddedOrder.Columns[0].ListView.Font = new Font(lstAddedOrder.Columns[0].ListView.Font, FontStyle.Bold);
                string[] row = {
                                    product.nameProduct,
                                    product.descriptionProduct,
                                    product.createdProduct.ToString("d"),
                                    product.updatedProduct.ToString("d"),
                                    product.costProduct.ToString(),
                                    statusName,
                                    statusID.ToString(),
                                    product.idProduct.ToString()
                                };

                ListViewItem listProduct1 = new ListViewItem(row);
                listProduct1.Font = new Font(listProduct1.Font, FontStyle.Regular);
                lstAddedOrder.Items.Add(listProduct1);
            }
        }

        ProductClass ListOfProduct = new ProductClass();
        private void btnAddListOfProduct_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                ListOfProduct.ammountProduct = Convert.ToInt32(txtAmountOrders.Text);
            }
            else
            {
                txtAmountOrders.Clear();
            }

            if (txtAmountOrders.TextLength > 0)
            {
                if (lstAddedOrder.SelectedItems.Count > 0)
                {
                    ListViewItem item = lstAddedOrder.SelectedItems[0];
                    ListOfProduct.nameProduct = item.SubItems[0].Text;
                    ListOfProduct.costProduct = Convert.ToDouble(item.SubItems[4].Text);
                    ListOfProduct.idProduct = Convert.ToInt32(item.SubItems[7].Text);
                   
                    double subtotalOrders = ListOfProduct.ammountProduct * ListOfProduct.costProduct;
                    lstOrder.Columns[0].ListView.Font = new Font(lstOrder.Columns[0].ListView.Font, FontStyle.Bold);
                    string[] row = {
                                    ListOfProduct.nameProduct,
                                    ListOfProduct.ammountProduct.ToString(),
                                    ListOfProduct.costProduct.ToString(),
                                    subtotalOrders.ToString(),
                                    ListOfProduct.idProduct.ToString()
                                };
                    ListViewItem listProduct = new ListViewItem(row);
                    listProduct.Font = new Font(listProduct.Font, FontStyle.Regular);
                    lstOrder.Items.Add(listProduct);
                    txtAmountOrders.Clear();
                    txtAmountOrders.Focus();
                }
                else
                {
                    MessageBox.Show("Please select a 'list of products'.");
                }
            }
            else
            {
                MessageBox.Show(" Please enter the amount of product ");
                txtAmountOrders.Focus();
            }
        }

        private void btnDeleteItemShopLIST_Click(object sender, EventArgs e)
        {
            if (lstOrder.SelectedItems.Count > 0)
            {
                DialogResult result1 = MessageBox.Show("Delete " + "Product" + "?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result1 == DialogResult.Yes)
                {
                    ListViewItem item1 = lstOrder.SelectedItems[0];
                    foreach (ListViewItem itemSelected in lstOrder.SelectedItems)
                    {
                        lstOrder.Items.Remove(itemSelected);
                        MessageBox.Show("Product deleted");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product first!");
            }
        }


        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (lstOrder.Items.Count == 0)
            {
                MessageBox.Show(" 'Please select items from a 'list of products' ");
            }
            else
            {
                if (comboBoxOrderProduct.SelectedIndex == 0)
                {
                    MessageBox.Show(" 'Please select a 'Client list' ");
                }
                else
                {
                    order.dateOrder = DateTime.Now;
                    decimal subtotal = 0;
                    for (int i = 0; i < lstOrder.Items.Count; i++)
                    {
                        subtotal += Convert.ToDecimal(lstOrder.Items[i].SubItems[3].Text);
                    }
                    order.subtotalOrders = subtotal;
                    order.taxOrder = (subtotal / 100) * 7;
                    order.totalOrder = (order.taxOrder + subtotal);
                    order.statusOrderId = 1;
                    order.client_id = (int)comboBoxOrderProduct.SelectedValue;

                    List<Order_Products> products = new List<Order_Products>();
                    for (int i = 0; i < lstOrder.Items.Count; i++)
                    {
                        Order_Products product = new Order_Products();
                        product.product_id = Convert.ToInt32(lstOrder.Items[i].SubItems[4].Text);
                        product.ammount = Convert.ToInt32(lstOrder.Items[i].SubItems[1].Text);
                        products.Add(product);
                    }
                    this.getOrder = order;
                    this.getProducts = products;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
        private bool IsValidData()
        {
            return
                Validator.IsInt32(txtAmountOrders) &&
                Validator.IsPresent(txtAmountOrders)&&
                Validator.IsWithinRange(txtAmountOrders,1,100);
               
        }
       

           
        

            private void btnCloseAddOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
