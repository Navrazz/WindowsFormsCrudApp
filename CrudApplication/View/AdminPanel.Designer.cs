namespace CrudApplication.View
{
    partial class AdminPanel
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
            this.dataGridViewShow = new System.Windows.Forms.DataGridView();
            this.buttonShowAllCustomers = new System.Windows.Forms.Button();
            this.buttonShowAllAdmins = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.buttonGiveAdmin = new System.Windows.Forms.Button();
            this.buttonShowAllProduct = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonRemoveAdmin = new System.Windows.Forms.Button();
            this.buttonAllOrders = new System.Windows.Forms.Button();
            this.buttonCustomerOrder = new System.Windows.Forms.Button();
            this.buttonMarkComplete = new System.Windows.Forms.Button();
            this.groupBoxControls = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).BeginInit();
            this.groupBoxControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewShow
            // 
            this.dataGridViewShow.AllowUserToAddRows = false;
            this.dataGridViewShow.AllowUserToDeleteRows = false;
            this.dataGridViewShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShow.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewShow.MultiSelect = false;
            this.dataGridViewShow.Name = "dataGridViewShow";
            this.dataGridViewShow.ReadOnly = true;
            this.dataGridViewShow.Size = new System.Drawing.Size(975, 278);
            this.dataGridViewShow.TabIndex = 0;
            this.dataGridViewShow.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewShow_RowHeaderMouseClick);
            // 
            // buttonShowAllCustomers
            // 
            this.buttonShowAllCustomers.Location = new System.Drawing.Point(15, 377);
            this.buttonShowAllCustomers.Name = "buttonShowAllCustomers";
            this.buttonShowAllCustomers.Size = new System.Drawing.Size(90, 38);
            this.buttonShowAllCustomers.TabIndex = 1;
            this.buttonShowAllCustomers.Text = "Show All Customers";
            this.buttonShowAllCustomers.UseVisualStyleBackColor = true;
            this.buttonShowAllCustomers.Click += new System.EventHandler(this.buttonShowAllCustomers_Click);
            // 
            // buttonShowAllAdmins
            // 
            this.buttonShowAllAdmins.Location = new System.Drawing.Point(111, 377);
            this.buttonShowAllAdmins.Name = "buttonShowAllAdmins";
            this.buttonShowAllAdmins.Size = new System.Drawing.Size(90, 38);
            this.buttonShowAllAdmins.TabIndex = 2;
            this.buttonShowAllAdmins.Text = "Show All Admins";
            this.buttonShowAllAdmins.UseVisualStyleBackColor = true;
            this.buttonShowAllAdmins.Click += new System.EventHandler(this.buttonShowAllAdmins_Click);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(198, 43);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(75, 38);
            this.buttonDeleteUser.TabIndex = 8;
            this.buttonDeleteUser.Text = "DeleteUser";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(180, 13);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 11;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(128, 16);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(49, 13);
            this.labelId.TabIndex = 5;
            this.labelId.Text = "Enter ID:";
            // 
            // buttonGiveAdmin
            // 
            this.buttonGiveAdmin.Location = new System.Drawing.Point(279, 43);
            this.buttonGiveAdmin.Name = "buttonGiveAdmin";
            this.buttonGiveAdmin.Size = new System.Drawing.Size(75, 38);
            this.buttonGiveAdmin.TabIndex = 9;
            this.buttonGiveAdmin.Text = "GiveAdmin";
            this.buttonGiveAdmin.UseVisualStyleBackColor = true;
            this.buttonGiveAdmin.Click += new System.EventHandler(this.buttonGiveAdmin_Click);
            // 
            // buttonShowAllProduct
            // 
            this.buttonShowAllProduct.Location = new System.Drawing.Point(207, 377);
            this.buttonShowAllProduct.Name = "buttonShowAllProduct";
            this.buttonShowAllProduct.Size = new System.Drawing.Size(90, 38);
            this.buttonShowAllProduct.TabIndex = 3;
            this.buttonShowAllProduct.Text = "Show All Products";
            this.buttonShowAllProduct.UseVisualStyleBackColor = true;
            this.buttonShowAllProduct.Click += new System.EventHandler(this.buttonShowAllProduct_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(303, 377);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(90, 38);
            this.buttonAddProduct.TabIndex = 4;
            this.buttonAddProduct.Text = "Add Product";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWelcome.Location = new System.Drawing.Point(340, 10);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(82, 20);
            this.labelWelcome.TabIndex = 7;
            this.labelWelcome.Text = "Welcome";
            // 
            // buttonRemoveAdmin
            // 
            this.buttonRemoveAdmin.Enabled = false;
            this.buttonRemoveAdmin.Location = new System.Drawing.Point(360, 43);
            this.buttonRemoveAdmin.Name = "buttonRemoveAdmin";
            this.buttonRemoveAdmin.Size = new System.Drawing.Size(75, 38);
            this.buttonRemoveAdmin.TabIndex = 10;
            this.buttonRemoveAdmin.Text = "Remove Admin";
            this.buttonRemoveAdmin.UseVisualStyleBackColor = true;
            this.buttonRemoveAdmin.Click += new System.EventHandler(this.buttonRemoveAdmin_Click);
            // 
            // buttonAllOrders
            // 
            this.buttonAllOrders.Location = new System.Drawing.Point(399, 377);
            this.buttonAllOrders.Name = "buttonAllOrders";
            this.buttonAllOrders.Size = new System.Drawing.Size(90, 38);
            this.buttonAllOrders.TabIndex = 5;
            this.buttonAllOrders.Text = "Show All Orders";
            this.buttonAllOrders.UseVisualStyleBackColor = true;
            this.buttonAllOrders.Click += new System.EventHandler(this.buttonAllOrders_Click);
            // 
            // buttonCustomerOrder
            // 
            this.buttonCustomerOrder.Location = new System.Drawing.Point(6, 43);
            this.buttonCustomerOrder.Name = "buttonCustomerOrder";
            this.buttonCustomerOrder.Size = new System.Drawing.Size(90, 38);
            this.buttonCustomerOrder.TabIndex = 6;
            this.buttonCustomerOrder.Text = "Show Customer Order";
            this.buttonCustomerOrder.UseVisualStyleBackColor = true;
            this.buttonCustomerOrder.Click += new System.EventHandler(this.buttonCustomerOrder_Click);
            // 
            // buttonMarkComplete
            // 
            this.buttonMarkComplete.Enabled = false;
            this.buttonMarkComplete.Location = new System.Drawing.Point(102, 43);
            this.buttonMarkComplete.Name = "buttonMarkComplete";
            this.buttonMarkComplete.Size = new System.Drawing.Size(90, 38);
            this.buttonMarkComplete.TabIndex = 7;
            this.buttonMarkComplete.Text = "Mark Order Complete";
            this.buttonMarkComplete.UseVisualStyleBackColor = true;
            this.buttonMarkComplete.Click += new System.EventHandler(this.buttonMarkComplete_Click);
            // 
            // groupBoxControls
            // 
            this.groupBoxControls.Controls.Add(this.buttonRemoveAdmin);
            this.groupBoxControls.Controls.Add(this.buttonMarkComplete);
            this.groupBoxControls.Controls.Add(this.buttonDeleteUser);
            this.groupBoxControls.Controls.Add(this.buttonCustomerOrder);
            this.groupBoxControls.Controls.Add(this.textBoxId);
            this.groupBoxControls.Controls.Add(this.labelId);
            this.groupBoxControls.Controls.Add(this.buttonGiveAdmin);
            this.groupBoxControls.Location = new System.Drawing.Point(542, 334);
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.Size = new System.Drawing.Size(445, 87);
            this.groupBoxControls.TabIndex = 10;
            this.groupBoxControls.TabStop = false;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 431);
            this.Controls.Add(this.groupBoxControls);
            this.Controls.Add(this.buttonAllOrders);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.buttonShowAllProduct);
            this.Controls.Add(this.buttonShowAllAdmins);
            this.Controls.Add(this.buttonShowAllCustomers);
            this.Controls.Add(this.dataGridViewShow);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).EndInit();
            this.groupBoxControls.ResumeLayout(false);
            this.groupBoxControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShow;
        private System.Windows.Forms.Button buttonShowAllCustomers;
        private System.Windows.Forms.Button buttonShowAllAdmins;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button buttonGiveAdmin;
        private System.Windows.Forms.Button buttonShowAllProduct;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonRemoveAdmin;
        private System.Windows.Forms.Button buttonAllOrders;
        private System.Windows.Forms.Button buttonCustomerOrder;
        private System.Windows.Forms.Button buttonMarkComplete;
        private System.Windows.Forms.GroupBox groupBoxControls;
    }
}