/*
 * Author - Raikhana Urazbaeva 
 * Form - For employees to add, modify, delete and manage products, orders and clients 
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
    public partial class Users : Form
    {
        public int user_id;
        public Users(int userID)
        {
            user_id = userID;
            InitializeComponent();
        }
        string statusName = "";
        int statusID = 0;
        private void Users_Load(object sender, EventArgs e)
        {
            FillListView();
            FillListViewClient();
            FillListViewProduct();
            FillListViewOrders();
            FillComboBoxOrderStatus();
        }

        private void FillListView()
        {
            lstUsersList.Columns[0].ListView.Font = new Font(lstUsersList.Columns[0].ListView.Font, FontStyle.Bold);
            lstUsersList.Items.Clear();
            List<UsersClass> users = new List<UsersClass>();
            users = UsersDB_Class.GetUsers();

            foreach (UsersClass user in users)
            {
                string[] row = {
                                    user.firstNameUsers,
                                    user.lastNameUsers,
                                    user.emailUsers,
                                    user.phoneUsers,
                                    user.createdUsers.ToString("d"),
                                    user.updatedUsers.ToString("d")
                                };

                ListViewItem listUser = new ListViewItem(row);
                listUser.Font = new Font(listUser.Font, FontStyle.Regular);
                lstUsersList.Items.Add(listUser);
            }
        }
        private void FillListViewClient()
        {
            lstClient.Columns[0].ListView.Font = new Font(lstClient.Columns[0].ListView.Font, FontStyle.Bold); //Bold
            lstClient.Items.Clear();
            List<ClientClass> clients = new List<ClientClass>();
            clients = ClientDB_Class.GetClients();

            foreach (ClientClass client in clients)
            {
                string[] row = {
                                    client.firstNameClient,
                                    client.lastNameClient,
                                    client.addressClient,
                                    client.cityClient,
                                    client.countryClient,
                                    client.postalCodeClient,
                                    client.companyClient,
                                    client.phoneClient.ToString(),
                                    client.paymentClient,
                                    client.emailClient,
                                    client.createdClient.ToString("d"),
                                    client.updatedClient.ToString("d"),
                                    client.idClient.ToString()

                                };

                ListViewItem listClient = new ListViewItem(row);
                listClient.Font = new Font(listClient.Font, FontStyle.Regular); //Regular
                lstClient.Items.Add(listClient);
            }
        }
        private void lstClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstClient.SelectedItems.Count > 0)
            {
                ListViewItem item = lstClient.SelectedItems[0];
                string firstNameClient = item.SubItems[0].Text;
                string lastNameClient = item.SubItems[1].Text;
                string addressClient = item.SubItems[2].Text;
                string cityClient = item.SubItems[3].Text;
                string countryClient = item.SubItems[4].Text; 
                string postalCodeClient = item.SubItems[5].Text;
                string companyClient = item.SubItems[6].Text;
                string phoneClient = item.SubItems[7].Text;
                string paymentClient = item.SubItems[8].Text;
                string emailClient = item.SubItems[9].Text;
                string createdClient = item.SubItems[10].Text;
                string updatedClient = item.SubItems[11].Text;
                int idClient = Convert.ToInt32(item.SubItems[12].Text);
            }
        }

        private void ModifyProfile_Click(object sender, EventArgs e)
        {
            ModifyProfile modifyProfile = new ModifyProfile(user_id);
            var result =  modifyProfile.ShowDialog();
            if (result == DialogResult.OK)
            {
                UsersClass modified = modifyProfile.modify;
                bool returnedResult = UsersDB_Class.ChangeUsers(modified);
                if (returnedResult)
                {
                    FillListView();
                    MessageBox.Show("User changed");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void lstUsersList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            AddClient addClientClick = new AddClient();
            var result = addClientClick.ShowDialog();
            if(result == DialogResult.OK)
            {
                ClientClass AddClient = addClientClick.added;
                bool returnedResult = ClientDB_Class.AddClient(AddClient);
                if (returnedResult)
                {
                    FillListViewClient();
                    MessageBox.Show("Client added");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
           
        }
        private void btnModifyClient_Click(object sender, EventArgs e) 
        {
            ClientClass modifyClient = new ClientClass();
            if (lstClient.SelectedItems.Count > 0)
            {
                ListViewItem item = lstClient.SelectedItems[0];
                modifyClient.firstNameClient = item.SubItems[0].Text;
                modifyClient.lastNameClient = item.SubItems[1].Text;
                modifyClient.addressClient = item.SubItems[2].Text;
                modifyClient.cityClient = item.SubItems[3].Text;
                modifyClient.countryClient = item.SubItems[4].Text;
                modifyClient.postalCodeClient = item.SubItems[5].Text;
                modifyClient.companyClient = item.SubItems[6].Text;
                modifyClient.phoneClient = item.SubItems[7].Text;
                modifyClient.paymentClient = item.SubItems[8].Text;
                modifyClient.emailClient = item.SubItems[9].Text;
                modifyClient.createdClient = Convert.ToDateTime(item.SubItems[10].Text);
                modifyClient.updatedClient = Convert.ToDateTime(item.SubItems[11].Text);
                modifyClient.idClient = Convert.ToInt32(item.SubItems[12].Text);

                ModifyCient updateClient = new ModifyCient(modifyClient);
                var result = updateClient.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ClientClass changedUser = updateClient.modified;
                    bool returnedResult = ClientDB_Class.ModifyClient(changedUser);
                    if (returnedResult)
                    {
                        FillListViewClient();
                        MessageBox.Show("Client changed");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a client ");
            }
        }


        private void btnReportClient_Click(object sender, EventArgs e)
        {
            ClientClass reportClient = new ClientClass();
            if (lstClient.SelectedItems.Count > 0)
            {
                ListViewItem item = lstClient.SelectedItems[0];
                reportClient.firstNameClient = item.SubItems[0].Text;
                reportClient.lastNameClient = item.SubItems[1].Text;
                reportClient.addressClient = item.SubItems[2].Text;
                reportClient.cityClient = item.SubItems[3].Text;
                reportClient.countryClient = item.SubItems[4].Text;
                reportClient.postalCodeClient = item.SubItems[5].Text;
                reportClient.companyClient = item.SubItems[6].Text;
                reportClient.phoneClient = item.SubItems[7].Text;
                reportClient.paymentClient = item.SubItems[8].Text;
                reportClient.emailClient = item.SubItems[9].Text;
                reportClient.createdClient = Convert.ToDateTime(item.SubItems[10].Text);
                reportClient.updatedClient = Convert.ToDateTime(item.SubItems[11].Text);
                reportClient.idClient = Convert.ToInt32(item.SubItems[12].Text);
                ReportClient report = new ReportClient(reportClient);
                report.Show(); 
            }
            else
            {
                MessageBox.Show("Please select a client ");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstClient.Columns[0].ListView.Font = new Font(lstClient.Columns[0].ListView.Font, FontStyle.Bold); //Bold
            lstClient.Items.Clear();
            List <ClientClass> searchClient = new List<ClientClass>();
            searchClient = ClientDB_Class.SearchClient(txtSearch.Text);
                foreach (ClientClass client in searchClient)
                {
                    string[] row = {
                                    client.firstNameClient,
                                    client.lastNameClient,
                                    client.addressClient,
                                    client.cityClient,
                                    client.countryClient,
                                    client.postalCodeClient,
                                    client.companyClient,
                                    client.phoneClient.ToString(),
                                    client.paymentClient,
                                    client.emailClient,
                                    client.createdClient.ToString("d"),
                                    client.updatedClient.ToString("d"),
                                    client.idClient.ToString()

                                    };

                    ListViewItem listClient = new ListViewItem(row);
                    listClient.Font = new Font(listClient.Font, FontStyle.Regular);
                    lstClient.Items.Add(listClient);
                }
        }
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            lstClient.Items.Clear();
            FillListViewClient();
            txtSearch.Clear();
        }


        private void FillListViewProduct()
        {
            lstProduct.Columns[0].ListView.Font = new Font(lstProduct.Columns[0].ListView.Font, FontStyle.Bold);
            lstProduct.Items.Clear();
            List<ProductClass> products = new List<ProductClass>();
            products = ProductDB_Class.GetProducts();

            List<ProductStatusClass> statuses = new List<ProductStatusClass>();
            statuses = Product_statusDBClass.GetProduct_status();

            foreach (ProductClass product in products)
            {
                foreach (ProductStatusClass status in statuses)
                {
                    if (product.idStatusProduct == status.id)
                    {
                        statusID = status.id;
                        statusName = status.status;
                    }
                }
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

                ListViewItem listProduct = new ListViewItem(row);
                listProduct.Font = new Font(listProduct.Font, FontStyle.Regular);
                lstProduct.Items.Add(listProduct);
            }
        }


        private void lstProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProduct.SelectedItems.Count > 0)
            {
                ListViewItem item = lstProduct.SelectedItems[0];
                string nameProduct = item.SubItems[0].Text;
                string descriptionProduct = item.SubItems[1].Text;
                string createdProduct = item.SubItems[2].Text;
                string updatedProduct = item.SubItems[3].Text;
                string costProduct = item.SubItems[4].Text;
                string idStatusProduct = item.SubItems[6].Text;
                string idProduct = item.SubItems[7].Text;
            }
        }


        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ProductClass modifyProduct = new ProductClass();
            String x = "AddProduct";
            AddProduct addProductClick = new AddProduct(x,modifyProduct);
            var result = addProductClick.ShowDialog();
            if (result == DialogResult.OK)
            {
                ProductClass AddProducts = addProductClick.added;
                bool returnedResult = ProductDB_Class.AddProduct(AddProducts);
                if(returnedResult)
                {
                    FillListViewProduct();
                    MessageBox.Show("Product added");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }
        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            ProductClass modifyProduct = new ProductClass();
            if (lstProduct.SelectedItems.Count > 0)
            {
                ListViewItem item = lstProduct.SelectedItems[0];
                modifyProduct.nameProduct = item.SubItems[0].Text;
                modifyProduct.descriptionProduct = item.SubItems[1].Text;
                modifyProduct.createdProduct = Convert.ToDateTime(item.SubItems[2].Text);
                modifyProduct.updatedProduct = Convert.ToDateTime(item.SubItems[3].Text);
                modifyProduct.costProduct = Convert.ToDouble(item.SubItems[4].Text);
                modifyProduct.idStatusProduct = Convert.ToInt32(item.SubItems[6].Text);
                modifyProduct.idProduct = Convert.ToInt32(item.SubItems[7].Text);

                String x = "ModifyProduct";
                AddProduct modifyProductClick = new AddProduct(x, modifyProduct);
                var result = modifyProductClick.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ProductClass modifyingProduct = modifyProductClick.modifiedProduct;
                    bool returnedResult = ProductDB_Class.ModifyProduct(modifyingProduct);
                    if (returnedResult)
                    {
                        FillListViewProduct();
                        MessageBox.Show("Product changed");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product ");
            }
        }


        private void btnDeleteProduct_Click(object sender, EventArgs e)  
        {
            if (lstProduct.SelectedItems.Count > 0)
            {
                DialogResult result1 = MessageBox.Show("Delete " + "Product" + "?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result1 == DialogResult.Yes)
                {
                    ListViewItem item = lstProduct.SelectedItems[0];
                    int idProduct = Convert.ToInt32(item.SubItems[7].Text);
                    bool result = ProductDB_Class.DeleteProduct(idProduct);
                    if (result)
                    {
                        FillListViewProduct();
                        MessageBox.Show("Product deleted");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product ");
            }
        }

        private void btnReportProduct_Click(object sender, EventArgs e)
        {
            ProductClass reportProduct = new ProductClass();
            if (lstProduct.SelectedItems.Count > 0)
            {
                ListViewItem item = lstProduct.SelectedItems[0];
                reportProduct.nameProduct = item.SubItems[0].Text;
                reportProduct.descriptionProduct = item.SubItems[1].Text;
                reportProduct.createdProduct = Convert.ToDateTime(item.SubItems[2].Text);
                reportProduct.updatedProduct = Convert.ToDateTime(item.SubItems[3].Text);
                reportProduct.costProduct = Convert.ToDouble(item.SubItems[4].Text);
                reportProduct.statusProduct = item.SubItems[5].Text;
                reportProduct.idStatusProduct = Convert.ToInt32(item.SubItems[6].Text);
                reportProduct.idProduct = Convert.ToInt32(item.SubItems[7].Text);

                ReportProduct report = new ReportProduct(reportProduct);
                report.Show();
            }
            else
            {
                MessageBox.Show("Please select a product ");
            }
        }


        private void btnSearchProduct_Click(object sender, EventArgs e) 
        {

            lstProduct.Columns[0].ListView.Font = new Font(lstProduct.Columns[0].ListView.Font, FontStyle.Bold); //Bold
            lstProduct.Items.Clear();
            List<ProductClass> searchProduct = new List<ProductClass>();
            searchProduct = ProductDB_Class.SearchProduct(txtSearchProduct.Text);
            foreach (ProductClass product in searchProduct)
            {
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

                ListViewItem listProduct = new ListViewItem(row);
                listProduct.Font = new Font(lstProduct.Font, FontStyle.Regular);
                lstProduct.Items.Add(listProduct);
            }
        }

        private void btnShowAllProduct_Click(object sender, EventArgs e)
        {
            lstProduct.Items.Clear();
            FillListViewProduct();
            txtSearchProduct.Clear();
        }


        private void FillListViewOrders()
        {
            lstOrder.Columns[0].ListView.Font = new Font(lstOrder.Columns[0].ListView.Font, FontStyle.Bold);
            lstOrder.Items.Clear();
            List<OrderClass> orders = new List<OrderClass>();
            orders = OrderDB_Class.GetOrders();

            foreach (OrderClass order in orders)
            {
                string[] row = {
                                     order.idOrders.ToString(),
                                     order.dateOrder.ToString("d"),
                                     order.subtotalOrders.ToString(),
                                     order.taxOrder.ToString(),
                                     order.totalOrder.ToString(),
                                     order.statusOrderId.ToString(),
                                     order.client_id.ToString()
                                };

                ListViewItem listOrder = new ListViewItem(row);
                listOrder.Font = new Font(listOrder.Font, FontStyle.Regular);
                lstOrder.Items.Add(listOrder);
            }
        }


        private void lstOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void btnDisplayProducts_Click(object sender, EventArgs e)
        {
            if (lstOrder.SelectedItems.Count > 0)
            {
                ListViewItem item = lstOrder.SelectedItems[0];
                int order_id = Convert.ToInt32(item.SubItems[0].Text);
                DisplayProducts display = new DisplayProducts(order_id);
                display.Show();
            }
            else
            {
                MessageBox.Show("'Please select  an 'Order list'");
            }
        }

        private void FillComboBoxOrderStatus()
        {
            List<OrderStatusClass> orders = new List<OrderStatusClass>();
            try
            {
                orders = ProductOrderStatusClassDB.GetOrderStatus();
                comboBoxOrderStatus.DataSource = orders;
                comboBoxOrderStatus.DisplayMember = "nameOrderStatus";
                comboBoxOrderStatus.ValueMember = "idOrderStatus";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            AddOrder addOrderClick = new AddOrder();
            var result = addOrderClick.ShowDialog();
            if(result == DialogResult.OK)
            {
                OrderClass orderClass = addOrderClick.getOrder;
                List<Order_Products> products = addOrderClick.getProducts;
                bool returnedResult = OrderDB_Class.AddOrder(orderClass, products);
                if (returnedResult)
                {
                    FillListViewOrders();
                    MessageBox.Show("Order added");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }
        private void comboBoxOrderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnChangeStatusOrder_Click(object sender, EventArgs e)
        {
            if (comboBoxOrderStatus.SelectedIndex == 0)
            {
                MessageBox.Show(" Select from 'Order status' ");
            }
            else
            {
                OrderClass ChangeStatus = new OrderClass();
                if (lstOrder.SelectedItems.Count > 0)
                {
                    ListViewItem item = lstOrder.SelectedItems[0];
                    ChangeStatus.idOrders = Convert.ToInt32(item.SubItems[0].Text);
                    ChangeStatus.statusOrderId = (int)comboBoxOrderStatus.SelectedValue;
                    bool returnedResult = OrderDB_Class.ChangeStatusOrder(ChangeStatus);
                    if (returnedResult)
                    {
                        FillListViewOrders();
                        MessageBox.Show("Order changed");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                else
                {
                    MessageBox.Show("'Please select  an 'Order list'.");


                }
            }
        }


        private void btnPrintOrder_Click(object sender, EventArgs e)
        {
            OrderClass reportOrder = new OrderClass();
            if (lstOrder.SelectedItems.Count > 0)
            {
                ListViewItem item = lstOrder.SelectedItems[0];
                reportOrder.idOrders = Convert.ToInt32(item.SubItems[0].Text);
                reportOrder.dateOrder = Convert.ToDateTime(item.SubItems[1].Text);
                reportOrder.subtotalOrders = Convert.ToDecimal(item.SubItems[2].Text);
                reportOrder.taxOrder = Convert.ToDecimal(item.SubItems[3].Text);
                reportOrder.totalOrder = Convert.ToDecimal(item.SubItems[4].Text);
                reportOrder.statusOrderId = Convert.ToInt32(item.SubItems[5].Text);
                PrintOrder printOrder = new PrintOrder(reportOrder, reportOrder.idOrders);
                printOrder.Show();
            }
            else
            {
                MessageBox.Show("Please select an order ");
            }
        }
       

        private void btnClouseUsers_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage page = tabControl1.TabPages[e.Index];
            Color col = e.Index == 0 ? Color.FromArgb(33, 150, 243) : Color.FromArgb(33, 150, 243);
            e.Graphics.FillRectangle(new SolidBrush(col), e.Bounds);

            Rectangle paddedBounds = e.Bounds;
            int yOffset = (e.State == DrawItemState.Selected) ? -2 : 1;
            paddedBounds.Offset(1, yOffset);
            TextRenderer.DrawText(e.Graphics, page.Text, Font, paddedBounds, page.ForeColor);
        }

        private void Users_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm form1 = new MainForm();
            form1.Show();
        }
    }
}

