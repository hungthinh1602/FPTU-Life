namespace GetData_Multi_Table
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
            this.dgvViewData = new System.Windows.Forms.DataGridView();
            this.btnGetBooks = new System.Windows.Forms.Button();
            this.btnGetPublisher = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewData
            // 
            this.dgvViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewData.Location = new System.Drawing.Point(28, 64);
            this.dgvViewData.Name = "dgvViewData";
            this.dgvViewData.Size = new System.Drawing.Size(428, 226);
            this.dgvViewData.TabIndex = 3;
            // 
            // btnGetBooks
            // 
            this.btnGetBooks.Location = new System.Drawing.Point(124, 22);
            this.btnGetBooks.Name = "btnGetBooks";
            this.btnGetBooks.Size = new System.Drawing.Size(75, 23);
            this.btnGetBooks.TabIndex = 2;
            this.btnGetBooks.Text = "Get Books";
            this.btnGetBooks.UseVisualStyleBackColor = true;
            this.btnGetBooks.Click += new System.EventHandler(this.btnGetBooks_Click);
            // 
            // btnGetPublisher
            // 
            this.btnGetPublisher.Location = new System.Drawing.Point(223, 22);
            this.btnGetPublisher.Name = "btnGetPublisher";
            this.btnGetPublisher.Size = new System.Drawing.Size(98, 23);
            this.btnGetPublisher.TabIndex = 2;
            this.btnGetPublisher.Text = "Get Publisher";
            this.btnGetPublisher.UseVisualStyleBackColor = true;
            this.btnGetPublisher.Click += new System.EventHandler(this.btnGetPublisher_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(28, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 310);
            this.Controls.Add(this.dgvViewData);
            this.Controls.Add(this.btnGetPublisher);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnGetBooks);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get Data on Multi Table";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewData;
        private System.Windows.Forms.Button btnGetBooks;
        private System.Windows.Forms.Button btnGetPublisher;
        private System.Windows.Forms.Button btnRefresh;
    }
}

