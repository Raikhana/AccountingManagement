namespace Example_Project
{
    partial class ReportProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportProduct));
            this.lstProductReport = new System.Windows.Forms.ListView();
            this.columnNameProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescriptionProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCreatedProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUpdatedProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCostProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStatusProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIdStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPrintReportProduct = new System.Windows.Forms.Button();
            this.btnReportProductClose = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // lstProductReport
            // 
            this.lstProductReport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNameProduct,
            this.columnDescriptionProduct,
            this.columnCreatedProduct,
            this.columnUpdatedProduct,
            this.columnCostProduct,
            this.columnStatusProduct,
            this.columnIdStatus,
            this.columnID});
            this.lstProductReport.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProductReport.Location = new System.Drawing.Point(18, 24);
            this.lstProductReport.Name = "lstProductReport";
            this.lstProductReport.Size = new System.Drawing.Size(897, 300);
            this.lstProductReport.TabIndex = 1;
            this.lstProductReport.UseCompatibleStateImageBehavior = false;
            this.lstProductReport.View = System.Windows.Forms.View.Details;
            // 
            // columnNameProduct
            // 
            this.columnNameProduct.Text = "Name";
            this.columnNameProduct.Width = 100;
            // 
            // columnDescriptionProduct
            // 
            this.columnDescriptionProduct.Text = "Description";
            this.columnDescriptionProduct.Width = 190;
            // 
            // columnCreatedProduct
            // 
            this.columnCreatedProduct.Text = "Created";
            this.columnCreatedProduct.Width = 120;
            // 
            // columnUpdatedProduct
            // 
            this.columnUpdatedProduct.Text = "Updated";
            this.columnUpdatedProduct.Width = 120;
            // 
            // columnCostProduct
            // 
            this.columnCostProduct.Text = "Cost";
            this.columnCostProduct.Width = 70;
            // 
            // columnStatusProduct
            // 
            this.columnStatusProduct.Text = "Status";
            this.columnStatusProduct.Width = 90;
            // 
            // columnIdStatus
            // 
            this.columnIdStatus.Text = "ID Status";
            this.columnIdStatus.Width = 120;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 80;
            // 
            // btnPrintReportProduct
            // 
            this.btnPrintReportProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnPrintReportProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintReportProduct.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReportProduct.ForeColor = System.Drawing.Color.White;
            this.btnPrintReportProduct.Location = new System.Drawing.Point(18, 339);
            this.btnPrintReportProduct.Name = "btnPrintReportProduct";
            this.btnPrintReportProduct.Size = new System.Drawing.Size(130, 50);
            this.btnPrintReportProduct.TabIndex = 30;
            this.btnPrintReportProduct.Text = "Print";
            this.btnPrintReportProduct.UseVisualStyleBackColor = false;
            this.btnPrintReportProduct.Click += new System.EventHandler(this.btnPrintReportProduct_Click);
            // 
            // btnReportProductClose
            // 
            this.btnReportProductClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnReportProductClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportProductClose.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportProductClose.ForeColor = System.Drawing.Color.White;
            this.btnReportProductClose.Location = new System.Drawing.Point(165, 339);
            this.btnReportProductClose.Name = "btnReportProductClose";
            this.btnReportProductClose.Size = new System.Drawing.Size(130, 50);
            this.btnReportProductClose.TabIndex = 31;
            this.btnReportProductClose.Text = "Close";
            this.btnReportProductClose.UseVisualStyleBackColor = false;
            this.btnReportProductClose.Click += new System.EventHandler(this.btnReportProductClose_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // ReportProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 407);
            this.Controls.Add(this.btnReportProductClose);
            this.Controls.Add(this.btnPrintReportProduct);
            this.Controls.Add(this.lstProductReport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportProduct";
            this.Text = "Report Product";
            this.Load += new System.EventHandler(this.ReportProduct_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstProductReport;
        public System.Windows.Forms.ColumnHeader columnNameProduct;
        private System.Windows.Forms.ColumnHeader columnDescriptionProduct;
        private System.Windows.Forms.ColumnHeader columnCostProduct;
        private System.Windows.Forms.ColumnHeader columnCreatedProduct;
        private System.Windows.Forms.ColumnHeader columnUpdatedProduct;
        private System.Windows.Forms.Button btnPrintReportProduct;
        private System.Windows.Forms.Button btnReportProductClose;
        private System.Windows.Forms.ColumnHeader columnStatusProduct;
        private System.Windows.Forms.ColumnHeader columnIdStatus;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}