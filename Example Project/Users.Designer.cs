namespace Example_Project
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.lstClient = new System.Windows.Forms.ListView();
            this.firstNameClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastNameClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.clientID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabClient = new System.Windows.Forms.TabPage();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnReportClient = new System.Windows.Forms.Button();
            this.btnModifyClient = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.btnShowAllProduct = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnReportProduct = new System.Windows.Forms.Button();
            this.btnModifyProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lstProduct = new System.Windows.Forms.ListView();
            this.columnNameProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescriptionProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCreatedProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUpdatedProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCostProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIdsStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabOrder = new System.Windows.Forms.TabPage();
            this.btnDisplayProducts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxOrderStatus = new System.Windows.Forms.ComboBox();
            this.btnPrintOrder = new System.Windows.Forms.Button();
            this.btnChangeStatusOrder = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.lstOrder = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDateOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSubtotalOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTaxOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTotalOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStatusIDOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnClientOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.lstUsersList = new System.Windows.Forms.ListView();
            this.columnFirstNameUsers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLastNameUsers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEmailUsers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPhoneUsers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCreadedUsers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUpdated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClouseUsers = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabOrder.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstClient
            // 
            this.lstClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.firstNameClient,
            this.lastNameClient,
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
            this.clientID});
            this.lstClient.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstClient.FullRowSelect = true;
            this.lstClient.GridLines = true;
            this.lstClient.HideSelection = false;
            this.lstClient.Location = new System.Drawing.Point(9, 16);
            this.lstClient.Name = "lstClient";
            this.lstClient.Size = new System.Drawing.Size(1448, 300);
            this.lstClient.TabIndex = 0;
            this.lstClient.UseCompatibleStateImageBehavior = false;
            this.lstClient.View = System.Windows.Forms.View.Details;
            this.lstClient.SelectedIndexChanged += new System.EventHandler(this.lstClient_SelectedIndexChanged);
            // 
            // firstNameClient
            // 
            this.firstNameClient.Text = "First Name";
            this.firstNameClient.Width = 110;
            // 
            // lastNameClient
            // 
            this.lastNameClient.Text = "last Name";
            this.lastNameClient.Width = 110;
            // 
            // addressClient
            // 
            this.addressClient.Text = "Address";
            this.addressClient.Width = 210;
            // 
            // cityClient
            // 
            this.cityClient.Text = "City";
            this.cityClient.Width = 85;
            // 
            // countryClient
            // 
            this.countryClient.Text = "Country";
            this.countryClient.Width = 85;
            // 
            // postalCodeClient
            // 
            this.postalCodeClient.Text = "Postal Code";
            this.postalCodeClient.Width = 100;
            // 
            // companyClient
            // 
            this.companyClient.Text = "Company";
            this.companyClient.Width = 100;
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
            this.emailClient.Width = 200;
            // 
            // createdClient
            // 
            this.createdClient.Text = "Created";
            this.createdClient.Width = 95;
            // 
            // updatedClient
            // 
            this.updatedClient.Text = "Updated";
            this.updatedClient.Width = 95;
            // 
            // clientID
            // 
            this.clientID.Text = "ID";
            this.clientID.Width = 50;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabClient);
            this.tabControl1.Controls.Add(this.tabProduct);
            this.tabControl1.Controls.Add(this.tabOrder);
            this.tabControl1.Controls.Add(this.tabUsers);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(75, 40);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1474, 447);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // tabClient
            // 
            this.tabClient.Controls.Add(this.btnShowAll);
            this.tabClient.Controls.Add(this.pictureBox1);
            this.tabClient.Controls.Add(this.btnSearch);
            this.tabClient.Controls.Add(this.txtSearch);
            this.tabClient.Controls.Add(this.btnReportClient);
            this.tabClient.Controls.Add(this.btnModifyClient);
            this.tabClient.Controls.Add(this.btnAddClient);
            this.tabClient.Controls.Add(this.lstClient);
            this.tabClient.ForeColor = System.Drawing.Color.White;
            this.tabClient.Location = new System.Drawing.Point(4, 44);
            this.tabClient.Name = "tabClient";
            this.tabClient.Size = new System.Drawing.Size(1466, 399);
            this.tabClient.TabIndex = 0;
            this.tabClient.Text = "Client";
            this.tabClient.UseVisualStyleBackColor = true;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(1328, 333);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(130, 50);
            this.btnShowAll.TabIndex = 24;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(825, 333);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1181, 333);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 50);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(881, 333);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(294, 50);
            this.txtSearch.TabIndex = 21;
            // 
            // btnReportClient
            // 
            this.btnReportClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnReportClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportClient.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportClient.Location = new System.Drawing.Point(304, 333);
            this.btnReportClient.Name = "btnReportClient";
            this.btnReportClient.Size = new System.Drawing.Size(130, 50);
            this.btnReportClient.TabIndex = 20;
            this.btnReportClient.Text = "Report";
            this.btnReportClient.UseVisualStyleBackColor = false;
            this.btnReportClient.Click += new System.EventHandler(this.btnReportClient_Click);
            // 
            // btnModifyClient
            // 
            this.btnModifyClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnModifyClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyClient.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyClient.Location = new System.Drawing.Point(157, 333);
            this.btnModifyClient.Name = "btnModifyClient";
            this.btnModifyClient.Size = new System.Drawing.Size(130, 50);
            this.btnModifyClient.TabIndex = 19;
            this.btnModifyClient.Text = "Modify";
            this.btnModifyClient.UseVisualStyleBackColor = false;
            this.btnModifyClient.Click += new System.EventHandler(this.btnModifyClient_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.Location = new System.Drawing.Point(9, 333);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(130, 50);
            this.btnAddClient.TabIndex = 16;
            this.btnAddClient.Text = "Add";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // tabProduct
            // 
            this.tabProduct.Controls.Add(this.btnShowAllProduct);
            this.tabProduct.Controls.Add(this.pictureBox2);
            this.tabProduct.Controls.Add(this.btnSearchProduct);
            this.tabProduct.Controls.Add(this.txtSearchProduct);
            this.tabProduct.Controls.Add(this.btnDeleteProduct);
            this.tabProduct.Controls.Add(this.btnReportProduct);
            this.tabProduct.Controls.Add(this.btnModifyProduct);
            this.tabProduct.Controls.Add(this.btnAddProduct);
            this.tabProduct.Controls.Add(this.lstProduct);
            this.tabProduct.ForeColor = System.Drawing.Color.White;
            this.tabProduct.Location = new System.Drawing.Point(4, 44);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Size = new System.Drawing.Size(1466, 399);
            this.tabProduct.TabIndex = 1;
            this.tabProduct.Text = "Product";
            this.tabProduct.UseVisualStyleBackColor = true;
            // 
            // btnShowAllProduct
            // 
            this.btnShowAllProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnShowAllProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllProduct.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllProduct.ForeColor = System.Drawing.Color.White;
            this.btnShowAllProduct.Location = new System.Drawing.Point(1307, 333);
            this.btnShowAllProduct.Name = "btnShowAllProduct";
            this.btnShowAllProduct.Size = new System.Drawing.Size(130, 50);
            this.btnShowAllProduct.TabIndex = 28;
            this.btnShowAllProduct.Text = "Show All";
            this.btnShowAllProduct.UseVisualStyleBackColor = false;
            this.btnShowAllProduct.Click += new System.EventHandler(this.btnShowAllProduct_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(804, 333);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchProduct.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProduct.ForeColor = System.Drawing.Color.White;
            this.btnSearchProduct.Location = new System.Drawing.Point(1160, 333);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(130, 50);
            this.btnSearchProduct.TabIndex = 26;
            this.btnSearchProduct.Text = "Search";
            this.btnSearchProduct.UseVisualStyleBackColor = false;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProduct.Location = new System.Drawing.Point(860, 333);
            this.txtSearchProduct.Multiline = true;
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(294, 50);
            this.txtSearchProduct.TabIndex = 25;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.Location = new System.Drawing.Point(308, 333);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(130, 50);
            this.btnDeleteProduct.TabIndex = 4;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnReportProduct
            // 
            this.btnReportProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnReportProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportProduct.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportProduct.Location = new System.Drawing.Point(454, 333);
            this.btnReportProduct.Name = "btnReportProduct";
            this.btnReportProduct.Size = new System.Drawing.Size(130, 50);
            this.btnReportProduct.TabIndex = 3;
            this.btnReportProduct.Text = "Report";
            this.btnReportProduct.UseVisualStyleBackColor = false;
            this.btnReportProduct.Click += new System.EventHandler(this.btnReportProduct_Click);
            // 
            // btnModifyProduct
            // 
            this.btnModifyProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnModifyProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyProduct.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyProduct.Location = new System.Drawing.Point(162, 333);
            this.btnModifyProduct.Name = "btnModifyProduct";
            this.btnModifyProduct.Size = new System.Drawing.Size(130, 50);
            this.btnModifyProduct.TabIndex = 2;
            this.btnModifyProduct.Text = "Modify";
            this.btnModifyProduct.UseVisualStyleBackColor = false;
            this.btnModifyProduct.Click += new System.EventHandler(this.btnModifyProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(16, 333);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(130, 50);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Add ";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lstProduct
            // 
            this.lstProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNameProduct,
            this.columnDescriptionProduct,
            this.columnCreatedProduct,
            this.columnUpdatedProduct,
            this.columnCostProduct,
            this.columnStatus,
            this.columnIdsStatus,
            this.columnID});
            this.lstProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProduct.FullRowSelect = true;
            this.lstProduct.GridLines = true;
            this.lstProduct.HideSelection = false;
            this.lstProduct.Location = new System.Drawing.Point(16, 17);
            this.lstProduct.Name = "lstProduct";
            this.lstProduct.Size = new System.Drawing.Size(1421, 300);
            this.lstProduct.TabIndex = 0;
            this.lstProduct.UseCompatibleStateImageBehavior = false;
            this.lstProduct.View = System.Windows.Forms.View.Details;
            this.lstProduct.SelectedIndexChanged += new System.EventHandler(this.lstProduct_SelectedIndexChanged);
            // 
            // columnNameProduct
            // 
            this.columnNameProduct.Text = "Name";
            this.columnNameProduct.Width = 180;
            // 
            // columnDescriptionProduct
            // 
            this.columnDescriptionProduct.Text = "Description";
            this.columnDescriptionProduct.Width = 300;
            // 
            // columnCreatedProduct
            // 
            this.columnCreatedProduct.Text = "Created";
            this.columnCreatedProduct.Width = 140;
            // 
            // columnUpdatedProduct
            // 
            this.columnUpdatedProduct.Text = "Updated";
            this.columnUpdatedProduct.Width = 140;
            // 
            // columnCostProduct
            // 
            this.columnCostProduct.Text = "Cost";
            this.columnCostProduct.Width = 140;
            // 
            // columnStatus
            // 
            this.columnStatus.Text = "Status";
            this.columnStatus.Width = 140;
            // 
            // columnIdsStatus
            // 
            this.columnIdsStatus.Text = "ID Status";
            this.columnIdsStatus.Width = 140;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 140;
            // 
            // tabOrder
            // 
            this.tabOrder.Controls.Add(this.btnDisplayProducts);
            this.tabOrder.Controls.Add(this.label1);
            this.tabOrder.Controls.Add(this.comboBoxOrderStatus);
            this.tabOrder.Controls.Add(this.btnPrintOrder);
            this.tabOrder.Controls.Add(this.btnChangeStatusOrder);
            this.tabOrder.Controls.Add(this.btnAddOrder);
            this.tabOrder.Controls.Add(this.lstOrder);
            this.tabOrder.ForeColor = System.Drawing.Color.White;
            this.tabOrder.Location = new System.Drawing.Point(4, 44);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.Size = new System.Drawing.Size(1466, 399);
            this.tabOrder.TabIndex = 2;
            this.tabOrder.Text = "Order";
            this.tabOrder.UseVisualStyleBackColor = true;
            // 
            // btnDisplayProducts
            // 
            this.btnDisplayProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnDisplayProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayProducts.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayProducts.Location = new System.Drawing.Point(605, 333);
            this.btnDisplayProducts.Name = "btnDisplayProducts";
            this.btnDisplayProducts.Size = new System.Drawing.Size(130, 50);
            this.btnDisplayProducts.TabIndex = 51;
            this.btnDisplayProducts.Text = "Display products";
            this.btnDisplayProducts.UseVisualStyleBackColor = false;
            this.btnDisplayProducts.Click += new System.EventHandler(this.btnDisplayProducts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(308, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 14);
            this.label1.TabIndex = 50;
            this.label1.Text = "Order status";
            // 
            // comboBoxOrderStatus
            // 
            this.comboBoxOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrderStatus.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOrderStatus.FormattingEnabled = true;
            this.comboBoxOrderStatus.Location = new System.Drawing.Point(311, 351);
            this.comboBoxOrderStatus.Name = "comboBoxOrderStatus";
            this.comboBoxOrderStatus.Size = new System.Drawing.Size(130, 26);
            this.comboBoxOrderStatus.TabIndex = 49;
            this.comboBoxOrderStatus.Tag = "Status";
            this.comboBoxOrderStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrderStatus_SelectedIndexChanged);
            // 
            // btnPrintOrder
            // 
            this.btnPrintOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnPrintOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintOrder.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintOrder.Location = new System.Drawing.Point(162, 333);
            this.btnPrintOrder.Name = "btnPrintOrder";
            this.btnPrintOrder.Size = new System.Drawing.Size(130, 50);
            this.btnPrintOrder.TabIndex = 3;
            this.btnPrintOrder.Text = "Print";
            this.btnPrintOrder.UseVisualStyleBackColor = false;
            this.btnPrintOrder.Click += new System.EventHandler(this.btnPrintOrder_Click);
            // 
            // btnChangeStatusOrder
            // 
            this.btnChangeStatusOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnChangeStatusOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeStatusOrder.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeStatusOrder.Location = new System.Drawing.Point(454, 333);
            this.btnChangeStatusOrder.Name = "btnChangeStatusOrder";
            this.btnChangeStatusOrder.Size = new System.Drawing.Size(130, 50);
            this.btnChangeStatusOrder.TabIndex = 2;
            this.btnChangeStatusOrder.Text = "Change";
            this.btnChangeStatusOrder.UseVisualStyleBackColor = false;
            this.btnChangeStatusOrder.Click += new System.EventHandler(this.btnChangeStatusOrder_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.Location = new System.Drawing.Point(18, 333);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(130, 50);
            this.btnAddOrder.TabIndex = 1;
            this.btnAddOrder.Text = "Add";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // lstOrder
            // 
            this.lstOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.columnDateOrder,
            this.columnSubtotalOrder,
            this.columnTaxOrder,
            this.columnTotalOrder,
            this.columnStatusIDOrder,
            this.columnClientOrder});
            this.lstOrder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOrder.FullRowSelect = true;
            this.lstOrder.GridLines = true;
            this.lstOrder.HideSelection = false;
            this.lstOrder.Location = new System.Drawing.Point(18, 16);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(1031, 282);
            this.lstOrder.TabIndex = 0;
            this.lstOrder.UseCompatibleStateImageBehavior = false;
            this.lstOrder.View = System.Windows.Forms.View.Details;
            this.lstOrder.SelectedIndexChanged += new System.EventHandler(this.lstOrder_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 100;
            // 
            // columnDateOrder
            // 
            this.columnDateOrder.Text = "Date";
            this.columnDateOrder.Width = 150;
            // 
            // columnSubtotalOrder
            // 
            this.columnSubtotalOrder.Text = "Subtotal";
            this.columnSubtotalOrder.Width = 150;
            // 
            // columnTaxOrder
            // 
            this.columnTaxOrder.Text = "Tax";
            this.columnTaxOrder.Width = 150;
            // 
            // columnTotalOrder
            // 
            this.columnTotalOrder.Text = "Total";
            this.columnTotalOrder.Width = 150;
            // 
            // columnStatusIDOrder
            // 
            this.columnStatusIDOrder.Text = "Status  Order ID";
            this.columnStatusIDOrder.Width = 150;
            // 
            // columnClientOrder
            // 
            this.columnClientOrder.Text = "Client Id";
            this.columnClientOrder.Width = 120;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.lstUsersList);
            this.tabUsers.ForeColor = System.Drawing.Color.White;
            this.tabUsers.Location = new System.Drawing.Point(4, 44);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(1466, 399);
            this.tabUsers.TabIndex = 3;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // lstUsersList
            // 
            this.lstUsersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFirstNameUsers,
            this.columnLastNameUsers,
            this.columnEmailUsers,
            this.columnPhoneUsers,
            this.columnCreadedUsers,
            this.columnUpdated});
            this.lstUsersList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUsersList.GridLines = true;
            this.lstUsersList.Location = new System.Drawing.Point(16, 17);
            this.lstUsersList.Name = "lstUsersList";
            this.lstUsersList.Size = new System.Drawing.Size(949, 300);
            this.lstUsersList.TabIndex = 3;
            this.lstUsersList.UseCompatibleStateImageBehavior = false;
            this.lstUsersList.View = System.Windows.Forms.View.Details;
            this.lstUsersList.SelectedIndexChanged += new System.EventHandler(this.lstUsersList_SelectedIndexChanged);
            // 
            // columnFirstNameUsers
            // 
            this.columnFirstNameUsers.Text = "First Name";
            this.columnFirstNameUsers.Width = 140;
            // 
            // columnLastNameUsers
            // 
            this.columnLastNameUsers.Text = "Last Name";
            this.columnLastNameUsers.Width = 140;
            // 
            // columnEmailUsers
            // 
            this.columnEmailUsers.Text = "Email";
            this.columnEmailUsers.Width = 170;
            // 
            // columnPhoneUsers
            // 
            this.columnPhoneUsers.Text = "Phone";
            this.columnPhoneUsers.Width = 140;
            // 
            // columnCreadedUsers
            // 
            this.columnCreadedUsers.Text = "Creaded";
            this.columnCreadedUsers.Width = 120;
            // 
            // columnUpdated
            // 
            this.columnUpdated.Text = "Updated";
            this.columnUpdated.Width = 120;
            // 
            // btnClouseUsers
            // 
            this.btnClouseUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnClouseUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClouseUsers.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClouseUsers.ForeColor = System.Drawing.Color.White;
            this.btnClouseUsers.Location = new System.Drawing.Point(1356, 489);
            this.btnClouseUsers.Name = "btnClouseUsers";
            this.btnClouseUsers.Size = new System.Drawing.Size(130, 50);
            this.btnClouseUsers.TabIndex = 2;
            this.btnClouseUsers.Text = "Close";
            this.btnClouseUsers.UseVisualStyleBackColor = false;
            this.btnClouseUsers.Click += new System.EventHandler(this.btnClouseUsers_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1207, 489);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Modify profile";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ModifyProfile_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 557);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnClouseUsers);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Users";
            this.Text = "Users";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Users_FormClosed);
            this.Load += new System.EventHandler(this.Users_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabClient.ResumeLayout(false);
            this.tabClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabProduct.ResumeLayout(false);
            this.tabProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabOrder.ResumeLayout(false);
            this.tabOrder.PerformLayout();
            this.tabUsers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstClient;
        private System.Windows.Forms.ColumnHeader firstNameClient;
        private System.Windows.Forms.ColumnHeader addressClient;
        private System.Windows.Forms.ColumnHeader companyClient;
        private System.Windows.Forms.ColumnHeader phoneClient;
        private System.Windows.Forms.ColumnHeader postalCodeClient;
        private System.Windows.Forms.ColumnHeader paymentClient;
        private System.Windows.Forms.ColumnHeader createdClient;
        private System.Windows.Forms.ColumnHeader updatedClient;
        private System.Windows.Forms.ColumnHeader cityClient;
        private System.Windows.Forms.ColumnHeader countryClient;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabClient;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.TabPage tabOrder;
        private System.Windows.Forms.Button btnClouseUsers;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnModifyProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ListView lstProduct;
        private System.Windows.Forms.ColumnHeader columnDescriptionProduct;
        private System.Windows.Forms.ColumnHeader columnCostProduct;
        private System.Windows.Forms.ColumnHeader columnCreatedProduct;
        private System.Windows.Forms.ColumnHeader columnUpdatedProduct;
        private System.Windows.Forms.Button btnReportProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnPrintOrder;
        private System.Windows.Forms.Button btnChangeStatusOrder;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.ListView lstOrder;
        private System.Windows.Forms.ColumnHeader columnDateOrder;
        private System.Windows.Forms.ColumnHeader columnSubtotalOrder;
        private System.Windows.Forms.ColumnHeader columnTaxOrder;
        private System.Windows.Forms.ColumnHeader columnTotalOrder;
        private System.Windows.Forms.ColumnHeader columnStatusIDOrder;
        private System.Windows.Forms.ListView lstUsersList;
        private System.Windows.Forms.ColumnHeader columnLastNameUsers;
        private System.Windows.Forms.ColumnHeader columnEmailUsers;
        private System.Windows.Forms.ColumnHeader columnPhoneUsers;
        private System.Windows.Forms.ColumnHeader columnCreadedUsers;
        private System.Windows.Forms.ColumnHeader columnUpdated;
        private System.Windows.Forms.Button btnModifyClient;
        private System.Windows.Forms.Button btnReportClient;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader lastNameClient;
        private System.Windows.Forms.ColumnHeader emailClient;
        private System.Windows.Forms.ColumnHeader clientID;
        private System.Windows.Forms.ColumnHeader columnStatus;
        private System.Windows.Forms.ColumnHeader columnIdsStatus;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ComboBox comboBoxOrderStatus;
        private System.Windows.Forms.ColumnHeader columnClientOrder;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnNameProduct;
        public System.Windows.Forms.ColumnHeader columnFirstNameUsers;
        public System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.Button btnDisplayProducts;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnShowAllProduct;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.TextBox txtSearchProduct;
    }
}