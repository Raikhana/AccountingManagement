/*
 * Author - Raikhana Urazbaeva 
 * Form - To view and print products
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
    public partial class ReportProduct : Form
    {
        public ProductClass products = new ProductClass();
        public ReportProduct(ProductClass product)
        {
            products = product;
            InitializeComponent();
        }
        private void ReportProduct_Load(object sender, EventArgs e)
        {
            lstProductReport.Columns[0].ListView.Font = new Font(lstProductReport.Columns[0].ListView.Font, FontStyle.Bold);
            string[] row = {
                                    products.nameProduct,
                                    products.descriptionProduct,
                                    products.createdProduct.ToString("d"),
                                    products.updatedProduct.ToString("d"),
                                    products.costProduct.ToString(),
                                    products.statusProduct,
                                    products.idStatusProduct.ToString(),
                                    products.idProduct.ToString(),
        };

            ListViewItem listProduct = new ListViewItem(row);
            listProduct.Font = new Font(listProduct.Font, FontStyle.Regular);
            lstProductReport.Items.Add(listProduct);
        }

        private void btnPrintReportProduct_Click(object sender, EventArgs e)
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
    }
}

       
    

