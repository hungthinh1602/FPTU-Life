namespace ReaderApp
{
    partial class frmReaderManager
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
            System.Windows.Forms.Label dateOfBirthLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label addressLabel;
            this.readersDataGridView = new System.Windows.Forms.DataGridView();
            this.readerIdTextBox = new System.Windows.Forms.TextBox();
            this.readerNameTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            readerIdLabel = new System.Windows.Forms.Label();
            readerNameLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.readersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // readerIdLabel
            // 
            readerIdLabel.AutoSize = true;
            readerIdLabel.Location = new System.Drawing.Point(50, 14);
            readerIdLabel.Name = "readerIdLabel";
            readerIdLabel.Size = new System.Drawing.Size(70, 16);
            readerIdLabel.TabIndex = 1;
            readerIdLabel.Text = "Reader Id:";
            // 
            // readerNameLabel
            // 
            readerNameLabel.AutoSize = true;
            readerNameLabel.Location = new System.Drawing.Point(50, 42);
            readerNameLabel.Name = "readerNameLabel";
            readerNameLabel.Size = new System.Drawing.Size(96, 16);
            readerNameLabel.TabIndex = 3;
            readerNameLabel.Text = "Reader Name:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(50, 70);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(65, 16);
            categoryLabel.TabIndex = 5;
            categoryLabel.Text = "Category:";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Location = new System.Drawing.Point(50, 99);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(84, 16);
            dateOfBirthLabel.TabIndex = 7;
            dateOfBirthLabel.Text = "Date Of Birth:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(50, 127);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(39, 16);
            dateLabel.TabIndex = 9;
            dateLabel.Text = "Date:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(50, 154);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(61, 16);
            addressLabel.TabIndex = 11;
            addressLabel.Text = "Address:";
            // 
            // readersDataGridView
            // 
            this.readersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readersDataGridView.Location = new System.Drawing.Point(42, 188);
            this.readersDataGridView.Name = "readersDataGridView";
            this.readersDataGridView.RowHeadersWidth = 51;
            this.readersDataGridView.RowTemplate.Height = 24;
            this.readersDataGridView.Size = new System.Drawing.Size(867, 315);
            this.readersDataGridView.TabIndex = 1;
            this.readersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.readersDataGridView_CellClick);
            // 
            // readerIdTextBox
            // 
            this.readerIdTextBox.Location = new System.Drawing.Point(152, 11);
            this.readerIdTextBox.Name = "readerIdTextBox";
            this.readerIdTextBox.Size = new System.Drawing.Size(258, 22);
            this.readerIdTextBox.TabIndex = 2;
            // 
            // readerNameTextBox
            // 
            this.readerNameTextBox.Location = new System.Drawing.Point(152, 39);
            this.readerNameTextBox.Name = "readerNameTextBox";
            this.readerNameTextBox.Size = new System.Drawing.Size(258, 22);
            this.readerNameTextBox.TabIndex = 4;
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(152, 95);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(258, 22);
            this.dateOfBirthDateTimePicker.TabIndex = 8;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.Location = new System.Drawing.Point(152, 123);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(258, 22);
            this.dateDateTimePicker.TabIndex = 10;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(152, 151);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(258, 22);
            this.addressTextBox.TabIndex = 12;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(318, 520);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(96, 38);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(417, 520);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(96, 38);
            this.btnInsert.TabIndex = 13;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(516, 520);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 38);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(615, 520);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 38);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(152, 67);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(258, 22);
            this.categoryTextBox.TabIndex = 6;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(219, 520);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(96, 38);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frmReaderManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 570);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(readerIdLabel);
            this.Controls.Add(this.readerIdTextBox);
            this.Controls.Add(readerNameLabel);
            this.Controls.Add(this.readerNameTextBox);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(dateOfBirthLabel);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.readersDataGridView);
            this.Name = "frmReaderManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReaderInformation ";
            this.Load += new System.EventHandler(this.frmReaderManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.readersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView readersDataGridView;
        private System.Windows.Forms.TextBox readerIdTextBox;
        private System.Windows.Forms.TextBox readerNameTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.Button btnLoad;
    }
}

