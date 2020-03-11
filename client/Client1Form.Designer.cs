namespace client
{
    partial class Form1
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
            this.btnWebshopName = new System.Windows.Forms.Button();
            this.btnProductList = new System.Windows.Forms.Button();
            this.btnGetProductInfo = new System.Windows.Forms.Button();
            this.lbProductId = new System.Windows.Forms.Label();
            this.tbProductID = new System.Windows.Forms.TextBox();
            this.btnBuyProduct = new System.Windows.Forms.Button();
            this.lbWebshopName = new System.Windows.Forms.Label();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.lstPrice = new System.Windows.Forms.ListBox();
            this.lstStock = new System.Windows.Forms.ListBox();
            this.lbBooksTitle = new System.Windows.Forms.Label();
            this.lbPriceTitle = new System.Windows.Forms.Label();
            this.lbStockTitle = new System.Windows.Forms.Label();
            this.lbProductInfo = new System.Windows.Forms.Label();
            this.lbNumClients = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWebshopName
            // 
            this.btnWebshopName.Location = new System.Drawing.Point(13, 13);
            this.btnWebshopName.Name = "btnWebshopName";
            this.btnWebshopName.Size = new System.Drawing.Size(152, 45);
            this.btnWebshopName.TabIndex = 0;
            this.btnWebshopName.Text = "Webshop Name";
            this.btnWebshopName.UseVisualStyleBackColor = true;
            this.btnWebshopName.Click += new System.EventHandler(this.btnWebshopName_Click);
            // 
            // btnProductList
            // 
            this.btnProductList.Location = new System.Drawing.Point(13, 64);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(152, 45);
            this.btnProductList.TabIndex = 1;
            this.btnProductList.Text = "Product List";
            this.btnProductList.UseVisualStyleBackColor = true;
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // btnGetProductInfo
            // 
            this.btnGetProductInfo.Location = new System.Drawing.Point(13, 115);
            this.btnGetProductInfo.Name = "btnGetProductInfo";
            this.btnGetProductInfo.Size = new System.Drawing.Size(152, 45);
            this.btnGetProductInfo.TabIndex = 2;
            this.btnGetProductInfo.Text = "Product Info";
            this.btnGetProductInfo.UseVisualStyleBackColor = true;
            this.btnGetProductInfo.Click += new System.EventHandler(this.btnGetProductInfo_Click);
            // 
            // lbProductId
            // 
            this.lbProductId.AutoSize = true;
            this.lbProductId.Location = new System.Drawing.Point(13, 167);
            this.lbProductId.Name = "lbProductId";
            this.lbProductId.Size = new System.Drawing.Size(78, 17);
            this.lbProductId.TabIndex = 3;
            this.lbProductId.Text = "Product ID:";
            // 
            // tbProductID
            // 
            this.tbProductID.Location = new System.Drawing.Point(98, 161);
            this.tbProductID.Name = "tbProductID";
            this.tbProductID.Size = new System.Drawing.Size(100, 22);
            this.tbProductID.TabIndex = 4;
            // 
            // btnBuyProduct
            // 
            this.btnBuyProduct.Location = new System.Drawing.Point(13, 189);
            this.btnBuyProduct.Name = "btnBuyProduct";
            this.btnBuyProduct.Size = new System.Drawing.Size(152, 45);
            this.btnBuyProduct.TabIndex = 5;
            this.btnBuyProduct.Text = "Buy Product";
            this.btnBuyProduct.UseVisualStyleBackColor = true;
            this.btnBuyProduct.Click += new System.EventHandler(this.btnBuyProduct_Click);
            // 
            // lbWebshopName
            // 
            this.lbWebshopName.AutoSize = true;
            this.lbWebshopName.Location = new System.Drawing.Point(429, 9);
            this.lbWebshopName.Name = "lbWebshopName";
            this.lbWebshopName.Size = new System.Drawing.Size(45, 17);
            this.lbWebshopName.TabIndex = 6;
            this.lbWebshopName.Text = "Name";
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 16;
            this.lstBooks.Location = new System.Drawing.Point(241, 64);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(160, 180);
            this.lstBooks.TabIndex = 7;
            // 
            // lstPrice
            // 
            this.lstPrice.FormattingEnabled = true;
            this.lstPrice.ItemHeight = 16;
            this.lstPrice.Location = new System.Drawing.Point(407, 64);
            this.lstPrice.Name = "lstPrice";
            this.lstPrice.Size = new System.Drawing.Size(134, 180);
            this.lstPrice.TabIndex = 8;
            // 
            // lstStock
            // 
            this.lstStock.FormattingEnabled = true;
            this.lstStock.ItemHeight = 16;
            this.lstStock.Location = new System.Drawing.Point(547, 64);
            this.lstStock.Name = "lstStock";
            this.lstStock.Size = new System.Drawing.Size(134, 180);
            this.lstStock.TabIndex = 9;
            // 
            // lbBooksTitle
            // 
            this.lbBooksTitle.AutoSize = true;
            this.lbBooksTitle.Location = new System.Drawing.Point(241, 41);
            this.lbBooksTitle.Name = "lbBooksTitle";
            this.lbBooksTitle.Size = new System.Drawing.Size(21, 17);
            this.lbBooksTitle.TabIndex = 10;
            this.lbBooksTitle.Text = "ID";
            // 
            // lbPriceTitle
            // 
            this.lbPriceTitle.AutoSize = true;
            this.lbPriceTitle.Location = new System.Drawing.Point(404, 41);
            this.lbPriceTitle.Name = "lbPriceTitle";
            this.lbPriceTitle.Size = new System.Drawing.Size(40, 17);
            this.lbPriceTitle.TabIndex = 11;
            this.lbPriceTitle.Text = "Price";
            // 
            // lbStockTitle
            // 
            this.lbStockTitle.AutoSize = true;
            this.lbStockTitle.Location = new System.Drawing.Point(544, 41);
            this.lbStockTitle.Name = "lbStockTitle";
            this.lbStockTitle.Size = new System.Drawing.Size(43, 17);
            this.lbStockTitle.TabIndex = 12;
            this.lbStockTitle.Text = "Stock";
            // 
            // lbProductInfo
            // 
            this.lbProductInfo.AutoSize = true;
            this.lbProductInfo.Location = new System.Drawing.Point(241, 251);
            this.lbProductInfo.Name = "lbProductInfo";
            this.lbProductInfo.Size = new System.Drawing.Size(0, 17);
            this.lbProductInfo.TabIndex = 13;
            // 
            // lbNumClients
            // 
            this.lbNumClients.AutoSize = true;
            this.lbNumClients.Location = new System.Drawing.Point(241, 251);
            this.lbNumClients.Name = "lbNumClients";
            this.lbNumClients.Size = new System.Drawing.Size(196, 17);
            this.lbNumClients.TabIndex = 14;
            this.lbNumClients.Text = "Number of connected clients: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 293);
            this.Controls.Add(this.lbNumClients);
            this.Controls.Add(this.lbProductInfo);
            this.Controls.Add(this.lbStockTitle);
            this.Controls.Add(this.lbPriceTitle);
            this.Controls.Add(this.lbBooksTitle);
            this.Controls.Add(this.lstStock);
            this.Controls.Add(this.lstPrice);
            this.Controls.Add(this.lstBooks);
            this.Controls.Add(this.lbWebshopName);
            this.Controls.Add(this.btnBuyProduct);
            this.Controls.Add(this.tbProductID);
            this.Controls.Add(this.lbProductId);
            this.Controls.Add(this.btnGetProductInfo);
            this.Controls.Add(this.btnProductList);
            this.Controls.Add(this.btnWebshopName);
            this.Name = "Form1";
            this.Text = "Client 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWebshopName;
        private System.Windows.Forms.Button btnProductList;
        private System.Windows.Forms.Button btnGetProductInfo;
        private System.Windows.Forms.Label lbProductId;
        private System.Windows.Forms.TextBox tbProductID;
        private System.Windows.Forms.Button btnBuyProduct;
        private System.Windows.Forms.Label lbWebshopName;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.ListBox lstPrice;
        private System.Windows.Forms.ListBox lstStock;
        private System.Windows.Forms.Label lbBooksTitle;
        private System.Windows.Forms.Label lbPriceTitle;
        private System.Windows.Forms.Label lbStockTitle;
        private System.Windows.Forms.Label lbProductInfo;
        private System.Windows.Forms.Label lbNumClients;
    }
}

