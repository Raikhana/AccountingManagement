/*
 * Author - Raikhana Urazbaeva 
 * Form - To view and print order information
 * June 2019
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_Project
{
    public partial class PrintOrder : Form
    {
        public int orderID;
        OrderClass orders = new OrderClass();
        public PrintOrder(OrderClass order, int order_id)
        {
            orderID = order_id;
            orders = order;
            InitializeComponent();
        }
        private void PrintOrder_Load(object sender, EventArgs e)
        {
            lstOrderPrint.Columns[0].ListView.Font = new Font(lstOrderPrint.Columns[0].ListView.Font, FontStyle.Bold);
            string[] row = {
                                    orders.idOrders.ToString(),
                                    orders.dateOrder.ToString("d"),
                                    orders.subtotalOrders.ToString(),
                                    orders.taxOrder.ToString(),
                                    orders.totalOrder.ToString(),
                                    orders.statusOrderId.ToString()};

            ListViewItem listOrder = new ListViewItem(row);
            listOrder.Font = new Font(listOrder.Font, FontStyle.Regular);
            lstOrderPrint.Items.Add(listOrder);

            FillListViewOrders();
        }
        private void FillListViewOrders()
        {
            List<ProductClass> products = new List<ProductClass>();
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
        private void btnPrintOrder_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }
        Bitmap memoryImage;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
        private void btnReportProductClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrintOrderClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
