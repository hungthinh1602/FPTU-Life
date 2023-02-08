namespace ProductApp
{
    partial class frmProductManager
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
            System.Windows.Forms.Label readerIdLabel;
            System.Windows.Forms.Label readerNameLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label addressLabel;
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            readerIdLabel = new System.Windows.Forms.Label();
            readerNameLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // readerIdLabel
            // 
            readerIdLabel.AutoSize = true;
            readerIdLabel.Location = new System.Drawing.Point(34, 17);
            readerIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            readerIdLabel.Name = "readerIdLabel";
            readerIdLabel.Size = new System.Drawing.Size(59, 13);
            readerIdLabel.TabIndex = 33;
            readerIdLabel.Text = "Product Id:";
            // 
            // readerNameLabel
            // 
            readerNameLabel.AutoSize = true;
            readerNameLabel.Location = new System.Drawing.Point(34, 40);
            readerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            readerNameLabel.Name = "readerNameLabel";
            readerNameLabel.Size = new System.Drawing.Size(78, 13);
            readerNameLabel.TabIndex = 35;
            readerNameLabel.Text = "Product Name:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(34, 63);
            categoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(52, 13);
            categoryLabel.TabIndex = 37;
            categoryLabel.Text = "Category:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(34, 109);
            dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 39;
            dateLabel.Text = "Date:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(34, 86);
            addressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(60, 13);
            addressLabel.TabIndex = 41;
            addressLabel.Text = "Description";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(408, 398);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 31);
            this.btnExit.TabIndex = 47;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(334, 398);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(72, 31);
            this.btnUpdate.TabIndex = 45;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(260, 398);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(72, 31);
            this.btnInsert.TabIndex = 44;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(111, 398);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(72, 31);
            this.btnLoad.TabIndex = 43;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(185, 398);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(72, 31);
            this.btnNew.TabIndex = 46;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.Location = new System.Drawing.Point(116, 15);
            this.productIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.Size = new System.Drawing.Size(194, 20);
            this.productIdTextBox.TabIndex = 34;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(116, 38);
            this.productNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(194, 20);
            this.productNameTextBox.TabIndex = 36;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(116, 60);
            this.categoryTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(194, 20);
            this.categoryTextBox.TabIndex = 38;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.Location = new System.Drawing.Point(116, 106);
            this.dateDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(194, 20);
            this.dateDateTimePicker.TabIndex = 40;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(116, 84);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(194, 20);
            this.descriptionTextBox.TabIndex = 42;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Location = new System.Drawing.Point(28, 159);
            this.productsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowHeadersWidth = 51;
            this.productsDataGridView.RowTemplate.Height = 24;
            this.productsDataGridView.Size = new System.Drawing.Size(548, 228);
            this.productsDataGridView.TabIndex = 32;
            // 
            // frmProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 446);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(readerIdLabel);
            this.Controls.Add(this.productIdTextBox);
            this.Controls.Add(readerNameLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.productsDataGridView);
            this.Name = "frmProductManager";
            this.Text = "ProductInformation";
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DataGridView productsDataGridView;
    }
}

