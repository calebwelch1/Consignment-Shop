namespace ConsignmentShop
{
    partial class Shop
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
            this.HeaderText = new System.Windows.Forms.Label();
            this.itemsListbox = new System.Windows.Forms.ListBox();
            this.ItemListBoxLabel = new System.Windows.Forms.Label();
            this.PurchaseItemButton = new System.Windows.Forms.Button();
            this.AddCartButton = new System.Windows.Forms.Button();
            this.ShoppingCartLabel = new System.Windows.Forms.Label();
            this.ShoppingCartListBox = new System.Windows.Forms.ListBox();
            this.StoreSalesLabel = new System.Windows.Forms.Label();
            this.vendorLabel = new System.Windows.Forms.Label();
            this.VendorListbox = new System.Windows.Forms.ListBox();
            this.StoreProfitValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HeaderText
            // 
            this.HeaderText.AutoSize = true;
            this.HeaderText.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderText.Location = new System.Drawing.Point(528, 124);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.Size = new System.Drawing.Size(164, 33);
            this.HeaderText.TabIndex = 0;
            this.HeaderText.Text = "Shop Demo";
            // 
            // itemsListbox
            // 
            this.itemsListbox.FormattingEnabled = true;
            this.itemsListbox.ItemHeight = 19;
            this.itemsListbox.Location = new System.Drawing.Point(135, 254);
            this.itemsListbox.Name = "itemsListbox";
            this.itemsListbox.Size = new System.Drawing.Size(357, 251);
            this.itemsListbox.TabIndex = 1;
            // 
            // ItemListBoxLabel
            // 
            this.ItemListBoxLabel.AutoSize = true;
            this.ItemListBoxLabel.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemListBoxLabel.Location = new System.Drawing.Point(140, 215);
            this.ItemListBoxLabel.Name = "ItemListBoxLabel";
            this.ItemListBoxLabel.Size = new System.Drawing.Size(134, 27);
            this.ItemListBoxLabel.TabIndex = 2;
            this.ItemListBoxLabel.Text = "Store Items";
            // 
            // PurchaseItemButton
            // 
            this.PurchaseItemButton.Location = new System.Drawing.Point(855, 511);
            this.PurchaseItemButton.Name = "PurchaseItemButton";
            this.PurchaseItemButton.Size = new System.Drawing.Size(200, 56);
            this.PurchaseItemButton.TabIndex = 3;
            this.PurchaseItemButton.Text = "Purchase";
            this.PurchaseItemButton.UseVisualStyleBackColor = true;
            this.PurchaseItemButton.Click += new System.EventHandler(this.PurchaseItemButton_Click);
            // 
            // AddCartButton
            // 
            this.AddCartButton.Location = new System.Drawing.Point(513, 339);
            this.AddCartButton.Name = "AddCartButton";
            this.AddCartButton.Size = new System.Drawing.Size(158, 56);
            this.AddCartButton.TabIndex = 4;
            this.AddCartButton.Text = "Add To Cart";
            this.AddCartButton.UseVisualStyleBackColor = true;
            this.AddCartButton.Click += new System.EventHandler(this.AddCartButton_Click);
            // 
            // ShoppingCartLabel
            // 
            this.ShoppingCartLabel.AutoSize = true;
            this.ShoppingCartLabel.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShoppingCartLabel.Location = new System.Drawing.Point(693, 215);
            this.ShoppingCartLabel.Name = "ShoppingCartLabel";
            this.ShoppingCartLabel.Size = new System.Drawing.Size(167, 27);
            this.ShoppingCartLabel.TabIndex = 6;
            this.ShoppingCartLabel.Text = "Shopping Cart";
            // 
            // ShoppingCartListBox
            // 
            this.ShoppingCartListBox.FormattingEnabled = true;
            this.ShoppingCartListBox.ItemHeight = 19;
            this.ShoppingCartListBox.Location = new System.Drawing.Point(698, 254);
            this.ShoppingCartListBox.Name = "ShoppingCartListBox";
            this.ShoppingCartListBox.Size = new System.Drawing.Size(357, 251);
            this.ShoppingCartListBox.TabIndex = 5;
            // 
            // StoreSalesLabel
            // 
            this.StoreSalesLabel.AutoSize = true;
            this.StoreSalesLabel.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreSalesLabel.Location = new System.Drawing.Point(712, 701);
            this.StoreSalesLabel.Name = "StoreSalesLabel";
            this.StoreSalesLabel.Size = new System.Drawing.Size(132, 27);
            this.StoreSalesLabel.TabIndex = 8;
            this.StoreSalesLabel.Text = "Store Profit";
            this.StoreSalesLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // vendorLabel
            // 
            this.vendorLabel.AutoSize = true;
            this.vendorLabel.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorLabel.Location = new System.Drawing.Point(140, 537);
            this.vendorLabel.Name = "vendorLabel";
            this.vendorLabel.Size = new System.Drawing.Size(102, 27);
            this.vendorLabel.TabIndex = 10;
            this.vendorLabel.Text = "Vendors";
            // 
            // VendorListbox
            // 
            this.VendorListbox.FormattingEnabled = true;
            this.VendorListbox.ItemHeight = 19;
            this.VendorListbox.Location = new System.Drawing.Point(135, 567);
            this.VendorListbox.Name = "VendorListbox";
            this.VendorListbox.Size = new System.Drawing.Size(357, 251);
            this.VendorListbox.TabIndex = 9;
            // 
            // StoreProfitValue
            // 
            this.StoreProfitValue.AutoSize = true;
            this.StoreProfitValue.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreProfitValue.Location = new System.Drawing.Point(851, 702);
            this.StoreProfitValue.Name = "StoreProfitValue";
            this.StoreProfitValue.Size = new System.Drawing.Size(68, 27);
            this.StoreProfitValue.TabIndex = 11;
            this.StoreProfitValue.Text = "$0.00";
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 801);
            this.Controls.Add(this.StoreProfitValue);
            this.Controls.Add(this.vendorLabel);
            this.Controls.Add(this.VendorListbox);
            this.Controls.Add(this.StoreSalesLabel);
            this.Controls.Add(this.ShoppingCartLabel);
            this.Controls.Add(this.ShoppingCartListBox);
            this.Controls.Add(this.AddCartButton);
            this.Controls.Add(this.PurchaseItemButton);
            this.Controls.Add(this.ItemListBoxLabel);
            this.Controls.Add(this.itemsListbox);
            this.Controls.Add(this.HeaderText);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Shop";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.Shop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderText;
        private System.Windows.Forms.ListBox itemsListbox;
        private System.Windows.Forms.Label ItemListBoxLabel;
        private System.Windows.Forms.Button PurchaseItemButton;
        private System.Windows.Forms.Button AddCartButton;
        private System.Windows.Forms.Label ShoppingCartLabel;
        private System.Windows.Forms.ListBox ShoppingCartListBox;
        private System.Windows.Forms.Label StoreSalesLabel;
        private System.Windows.Forms.Label vendorLabel;
        private System.Windows.Forms.ListBox VendorListbox;
        private System.Windows.Forms.Label StoreProfitValue;
    }
}

