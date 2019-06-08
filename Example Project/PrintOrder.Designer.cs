namespace Example_Project
{
    partial class PrintOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintOrder));
            this.lstOrderPrint = new System.Windows.Forms.ListView();
            this.columnIDOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDateOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSubtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTaxOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTotalOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStatusOrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPrintOrder = new System.Windows.Forms.Button();
            this.btnPrintOrderClose = new System.Windows.Forms.Button();
            this.lstDisplayProduct = new System.Windows.Forms.ListView();
            this.columnProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCostOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // lstOrderPrint
            // 
            this.lstOrderPrint.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIDOrder,
            this.columnDateOrder,
            this.columnSubtotal,
            this.columnTaxOrder,
            this.columnTotalOrder,
            this.columnStatusOrderID});
            this.lstOrderPrint.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOrderPrint.Location = new System.Drawing.Point(15, 37);
            this.lstOrderPrint.Name = "lstOrderPrint";
            this.lstOrderPrint.Size = new System.Drawing.Size(802, 200);
            this.lstOrderPrint.TabIndex = 1;
            this.lstOrderPrint.UseCompatibleStateImageBehavior = false;
            this.lstOrderPrint.View = System.Windows.Forms.View.Details;
            // 
            // columnIDOrder
            // 
            this.columnIDOrder.Text = "ID";
            this.columnIDOrder.Width = 100;
            // 
            // columnDateOrder
            // 
            this.columnDateOrder.Text = "Date";
            this.columnDateOrder.Width = 150;
            // 
            // columnSubtotal
            // 
            this.columnSubtotal.Text = "Subtotal";
            this.columnSubtotal.Width = 100;
            // 
            // columnTaxOrder
            // 
            this.columnTaxOrder.Text = "Tax";
            this.columnTaxOrder.Width = 110;
            // 
            // columnTotalOrder
            // 
            this.columnTotalOrder.Text = "Total";
            this.columnTotalOrder.Width = 110;
            // 
            // columnStatusOrderID
            // 
            this.columnStatusOrderID.Text = "Status  Order ID";
            this.columnStatusOrderID.Width = 150;
            // 
            // btnPrintOrder
            // 
            this.btnPrintOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnPrintOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintOrder.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintOrder.ForeColor = System.Drawing.Color.White;
            this.btnPrintOrder.Location = new System.Drawing.Point(15, 537);
            this.btnPrintOrder.Name = "btnPrintOrder";
            this.btnPrintOrder.Size = new System.Drawing.Size(130, 50);
            this.btnPrintOrder.TabIndex = 2;
            this.btnPrintOrder.TabStop = false;
            this.btnPrintOrder.Text = "Print";
            this.btnPrintOrder.UseVisualStyleBackColor = false;
            this.btnPrintOrder.Click += new System.EventHandler(this.btnPrintOrder_Click);
            // 
            // btnPrintOrderClose
            // 
            this.btnPrintOrderClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnPrintOrderClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintOrderClose.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintOrderClose.ForeColor = System.Drawing.Color.White;
            this.btnPrintOrderClose.Location = new System.Drawing.Point(170, 537);
            this.btnPrintOrderClose.Name = "btnPrintOrderClose";
            this.btnPrintOrderClose.Size = new System.Drawing.Size(130, 50);
            this.btnPrintOrderClose.TabIndex = 38;
            this.btnPrintOrderClose.TabStop = false;
            this.btnPrintOrderClose.Text = "Close";
            this.btnPrintOrderClose.UseVisualStyleBackColor = false;
            this.btnPrintOrderClose.Click += new System.EventHandler(this.btnPrintOrderClose_Click);
            // 
            // lstDisplayProduct
            // 
            this.lstDisplayProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnProduct,
            this.columnDescription,
            this.columnCostOrder,
            this.columnAmount});
            this.lstDisplayProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDisplayProduct.FullRowSelect = true;
            this.lstDisplayProduct.Location = new System.Drawing.Point(17, 313);
            this.lstDisplayProduct.Name = "lstDisplayProduct";
            this.lstDisplayProduct.Size = new System.Drawing.Size(800, 200);
            this.lstDisplayProduct.TabIndex = 39;
            this.lstDisplayProduct.UseCompatibleStateImageBehavior = false;
            this.lstDisplayProduct.View = System.Windows.Forms.View.Details;
            // 
            // columnProduct
            // 
            this.columnProduct.Text = "Product";
            this.columnProduct.Width = 130;
            // 
            // columnDescription
            // 
            this.columnDescription.Text = "Description";
            this.columnDescription.Width = 170;
            // 
            // columnCostOrder
            // 
            this.columnCostOrder.Text = "Cost";
            this.columnCostOrder.Width = 150;
            // 
            // columnAmount
            // 
            this.columnAmount.Text = "Amount";
            this.columnAmount.Width = 100;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 19);
            this.label8.TabIndex = 53;
            this.label8.Text = "List of products";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 54;
            this.label1.Text = "Order";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // PrintOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 613);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstDisplayProduct);
            this.Controls.Add(this.btnPrintOrderClose);
            this.Controls.Add(this.btnPrintOrder);
            this.Controls.Add(this.lstOrderPrint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrintOrder";
            this.Text = "Print Order";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PrintOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstOrderPrint;
        private System.Windows.Forms.ColumnHeader columnDateOrder;
        private System.Windows.Forms.ColumnHeader columnTaxOrder;
        private System.Windows.Forms.ColumnHeader columnTotalOrder;
        private System.Windows.Forms.Button btnPrintOrder;
        private System.Windows.Forms.Button btnPrintOrderClose;
        private System.Windows.Forms.ColumnHeader columnStatusOrderID;
        private System.Windows.Forms.ListView lstDisplayProduct;
        private System.Windows.Forms.ColumnHeader columnProduct;
        private System.Windows.Forms.ColumnHeader columnDescription;
        private System.Windows.Forms.ColumnHeader columnCostOrder;
        private System.Windows.Forms.ColumnHeader columnAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnIDOrder;
        private System.Windows.Forms.ColumnHeader columnSubtotal;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}