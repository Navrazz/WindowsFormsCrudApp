namespace CrudApplication.View
{
    partial class CustomerPanel
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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.dataGridViewShow = new System.Windows.Forms.DataGridView();
            this.buttonShowAllProduct = new System.Windows.Forms.Button();
            this.buttonShowMyOrders = new System.Windows.Forms.Button();
            this.buttonOrderProduct = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWelcome.Location = new System.Drawing.Point(340, 10);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(82, 20);
            this.labelWelcome.TabIndex = 8;
            this.labelWelcome.Text = "Welcome";
            // 
            // dataGridViewShow
            // 
            this.dataGridViewShow.AllowUserToAddRows = false;
            this.dataGridViewShow.AllowUserToDeleteRows = false;
            this.dataGridViewShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShow.Location = new System.Drawing.Point(12, 55);
            this.dataGridViewShow.Name = "dataGridViewShow";
            this.dataGridViewShow.Size = new System.Drawing.Size(975, 278);
            this.dataGridViewShow.TabIndex = 9;
            this.dataGridViewShow.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewShow_RowHeaderMouseClick);
            // 
            // buttonShowAllProduct
            // 
            this.buttonShowAllProduct.Location = new System.Drawing.Point(12, 381);
            this.buttonShowAllProduct.Name = "buttonShowAllProduct";
            this.buttonShowAllProduct.Size = new System.Drawing.Size(75, 38);
            this.buttonShowAllProduct.TabIndex = 10;
            this.buttonShowAllProduct.Text = "Show all products";
            this.buttonShowAllProduct.UseVisualStyleBackColor = true;
            this.buttonShowAllProduct.Click += new System.EventHandler(this.buttonShowAllProduct_Click);
            // 
            // buttonShowMyOrders
            // 
            this.buttonShowMyOrders.Location = new System.Drawing.Point(93, 381);
            this.buttonShowMyOrders.Name = "buttonShowMyOrders";
            this.buttonShowMyOrders.Size = new System.Drawing.Size(75, 38);
            this.buttonShowMyOrders.TabIndex = 11;
            this.buttonShowMyOrders.Text = "Show my orders";
            this.buttonShowMyOrders.UseVisualStyleBackColor = true;
            this.buttonShowMyOrders.Click += new System.EventHandler(this.buttonShowMyOrders_Click);
            // 
            // buttonOrderProduct
            // 
            this.buttonOrderProduct.Location = new System.Drawing.Point(912, 373);
            this.buttonOrderProduct.Name = "buttonOrderProduct";
            this.buttonOrderProduct.Size = new System.Drawing.Size(75, 46);
            this.buttonOrderProduct.TabIndex = 12;
            this.buttonOrderProduct.Text = "Order Product";
            this.buttonOrderProduct.UseVisualStyleBackColor = true;
            this.buttonOrderProduct.Click += new System.EventHandler(this.buttonOrderProduct_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(751, 376);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(49, 13);
            this.labelId.TabIndex = 13;
            this.labelId.Text = "Enter ID:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(806, 373);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 14;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(723, 402);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(77, 13);
            this.labelQuantity.TabIndex = 13;
            this.labelQuantity.Text = "Enter Quantity:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(806, 399);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantity.TabIndex = 14;
            // 
            // CustomerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 431);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonOrderProduct);
            this.Controls.Add(this.buttonShowMyOrders);
            this.Controls.Add(this.buttonShowAllProduct);
            this.Controls.Add(this.dataGridViewShow);
            this.Controls.Add(this.labelWelcome);
            this.Name = "CustomerPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Panel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.DataGridView dataGridViewShow;
        private System.Windows.Forms.Button buttonShowAllProduct;
        private System.Windows.Forms.Button buttonShowMyOrders;
        private System.Windows.Forms.Button buttonOrderProduct;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxQuantity;
    }
}