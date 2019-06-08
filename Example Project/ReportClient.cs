/*
 * Author - Raikhana Urazbaeva 
 * Form - To view and print clients information
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
    public partial class ReportClient : Form
    {
        public ClientClass addclient = new ClientClass();
        public ReportClient(ClientClass client)
        {
            addclient = client;
            InitializeComponent();
        }
      
        private void ReportClient_Load(object sender, EventArgs e)
        {
            lstClientReport.Columns[0].ListView.Font = new Font(lstClientReport.Columns[0].ListView.Font, FontStyle.Bold);
            string[] row = {
                                    addclient.firstNameClient,
                                    addclient.lastNameClient,
                                    addclient.addressClient,
                                    addclient.cityClient,
                                    addclient.countryClient,
                                    addclient.postalCodeClient,
                                    addclient.companyClient,
                                    addclient.phoneClient,
                                    addclient.paymentClient,
                                    addclient.emailClient,
                                    addclient.createdClient.ToString("d"),
                                    addclient.updatedClient.ToString("d"),
                                    addclient.idClient.ToString()
                                };

            ListViewItem listUser = new ListViewItem(row);
            listUser.Font = new Font(listUser.Font, FontStyle.Regular);
            lstClientReport.Items.Add(listUser);

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

        private void btnReportClientClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
