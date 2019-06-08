namespace Example_Project
{
    partial class ReportClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportClient));
            this.btnPrintOrder = new System.Windows.Forms.Button();
            this.lstClientReport = new System.Windows.Forms.ListView();
            this.first_nameClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.last_NameClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addressClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cityClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.countryClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.postalCodeClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.companyClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.paymentClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emailClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.createdClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.updatedClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReportClientClose = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // btnPrintOrder
            // 
            this.btnPrintOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnPrintOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintOrder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintOrder.ForeColor = System.Drawing.Color.White;
            this.btnPrintOrder.Location = new System.Drawing.Point(12, 346);
            this.btnPrintOrder.Name = "btnPrintOrder";
            this.btnPrintOrder.Size = new System.Drawing.Size(130, 50);
            this.btnPrintOrder.TabIndex = 0;
            this.btnPrintOrder.Text = "Print";
            this.btnPrintOrder.UseVisualStyleBackColor = false;
            this.btnPrintOrder.Click += new System.EventHandler(this.btnPrintOrder_Click);
            // 
            // lstClientReport
            // 
            this.lstClientReport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.first_nameClient,
            this.last_NameClient,
            this.addressClient,
            this.cityClient,
            this.countryClient,
            this.postalCodeClient,
            this.companyClient,
            this.phoneClient,
            this.paymentClient,
            this.emailClient,
            this.createdClient,
            this.updatedClient,
            this.idClient});
            this.lstClientReport.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstClientReport.Location = new System.Drawing.Point(13, 30);
            this.lstClientReport.Name = "lstClientReport";
            this.lstClientReport.Size = new System.Drawing.Size(1287, 300);
            this.lstClientReport.TabIndex = 1;
            this.lstClientReport.UseCompatibleStateImageBehavior = false;
            this.lstClientReport.View = System.Windows.Forms.View.Details;
            // 
            // first_nameClient
            // 
            this.first_nameClient.Text = "First Name";
            this.first_nameClient.Width = 90;
            // 
            // last_NameClient
            // 
            this.last_NameClient.Text = "Last Name";
            this.last_NameClient.Width = 90;
            // 
            // addressClient
            // 
            this.addressClient.Text = "Address";
            this.addressClient.Width = 150;
            // 
            // cityClient
            // 
            this.cityClient.Text = "City";
            this.cityClient.Width = 90;
            // 
            // countryClient
            // 
            this.countryClient.Text = "Country";
            this.countryClient.Width = 90;
            // 
            // postalCodeClient
            // 
            this.postalCodeClient.Text = "Postal Code";
            this.postalCodeClient.Width = 100;
            // 
            // companyClient
            // 
            this.companyClient.Text = "Company";
            this.companyClient.Width = 90;
            // 
            // phoneClient
            // 
            this.phoneClient.Text = "Phone";
            this.phoneClient.Width = 100;
            // 
            // paymentClient
            // 
            this.paymentClient.Text = "Payment";
            this.paymentClient.Width = 80;
            // 
            // emailClient
            // 
            this.emailClient.Text = "Email";
            this.emailClient.Width = 150;
            // 
            // createdClient
            // 
            this.createdClient.Text = "Created";
            this.createdClient.Width = 90;
            // 
            // updatedClient
            // 
            this.updatedClient.Text = "Updated";
            this.updatedClient.Width = 90;
            // 
            // idClient
            // 
            this.idClient.Text = "ID";
            this.idClient.Width = 50;
            // 
            // btnReportClientClose
            // 
            this.btnReportClientClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnReportClientClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportClientClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportClientClose.ForeColor = System.Drawing.Color.White;
            this.btnReportClientClose.Location = new System.Drawing.Point(164, 346);
            this.btnReportClientClose.Name = "btnReportClientClose";
            this.btnReportClientClose.Size = new System.Drawing.Size(130, 50);
            this.btnReportClientClose.TabIndex = 40;
            this.btnReportClientClose.Text = "Close";
            this.btnReportClientClose.UseVisualStyleBackColor = false;
            this.btnReportClientClose.Click += new System.EventHandler(this.btnReportClientClose_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // ReportClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 414);
            this.Controls.Add(this.btnReportClientClose);
            this.Controls.Add(this.lstClientReport);
            this.Controls.Add(this.btnPrintOrder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportClient";
            this.Text = "Report Client";
            this.Load += new System.EventHandler(this.ReportClient_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrintOrder;
        private System.Windows.Forms.ListView lstClientReport;
        private System.Windows.Forms.ColumnHeader first_nameClient;
        private System.Windows.Forms.ColumnHeader addressClient;
        private System.Windows.Forms.ColumnHeader companyClient;
        private System.Windows.Forms.ColumnHeader phoneClient;
        private System.Windows.Forms.ColumnHeader postalCodeClient;
        private System.Windows.Forms.ColumnHeader paymentClient;
        private System.Windows.Forms.ColumnHeader createdClient;
        private System.Windows.Forms.ColumnHeader updatedClient;
        private System.Windows.Forms.ColumnHeader cityClient;
        private System.Windows.Forms.ColumnHeader countryClient;
        private System.Windows.Forms.Button btnReportClientClose;
        private System.Windows.Forms.ColumnHeader last_NameClient;
        private System.Windows.Forms.ColumnHeader emailClient;
        private System.Windows.Forms.ColumnHeader idClient;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}