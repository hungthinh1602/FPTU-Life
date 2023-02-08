namespace GetData_1_Table_DataReader
{
    partial class frmMain
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
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.btnGetBooks = new System.Windows.Forms.Button();
            this.lstBookName = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(36, 69);
            this.dgvBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.Size = new System.Drawing.Size(427, 278);
            this.dgvBooks.TabIndex = 3;
            // 
            // btnGetBooks
            // 
            this.btnGetBooks.Location = new System.Drawing.Point(36, 17);
            this.btnGetBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetBooks.Name = "btnGetBooks";
            this.btnGetBooks.Size = new System.Drawing.Size(100, 28);
            this.btnGetBooks.TabIndex = 2;
            this.btnGetBooks.Text = "Get Books";
            this.btnGetBooks.UseVisualStyleBackColor = true;
            this.btnGetBooks.Click += new System.EventHandler(this.btnGetBooks_Click);
            // 
            // lstBookName
            // 
            this.lstBookName.FormattingEnabled = true;
            this.lstBookName.ItemHeight = 16;
            this.lstBookName.Location = new System.Drawing.Point(471, 69);
            this.lstBookName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstBookName.Name = "lstBookName";
            this.lstBookName.Size = new System.Drawing.Size(159, 276);
            this.lstBookName.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 374);
            this.Controls.Add(this.lstBookName);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.btnGetBooks);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get Data by DataReader";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Button btnGetBooks;
        private System.Windows.Forms.ListBox lstBookName;
    }
}

