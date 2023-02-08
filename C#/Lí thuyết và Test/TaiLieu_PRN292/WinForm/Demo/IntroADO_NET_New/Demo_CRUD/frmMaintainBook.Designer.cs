namespace IntroADO_NET
{
    partial class frmMaintainBook
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitleFilter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBookQuantity = new System.Windows.Forms.TextBox();
            this.lbTotalQuantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(295, 153);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(67, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(104, 153);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(63, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(205, 153);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "BookID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "BookTitle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "BookPrice";
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(102, 8);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(131, 20);
            this.txtBookID.TabIndex = 2;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(102, 41);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(131, 20);
            this.txtBookTitle.TabIndex = 2;
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.Location = new System.Drawing.Point(102, 74);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.Size = new System.Drawing.Size(131, 20);
            this.txtBookPrice.TabIndex = 2;
            // 
            // dgvBookList
            // 
            this.dgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookList.Location = new System.Drawing.Point(12, 207);
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.Size = new System.Drawing.Size(433, 168);
            this.dgvBookList.TabIndex = 3;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(14, 153);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(63, 23);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Enter title";
            // 
            // txtTitleFilter
            // 
            this.txtTitleFilter.Location = new System.Drawing.Point(73, 383);
            this.txtTitleFilter.Name = "txtTitleFilter";
            this.txtTitleFilter.Size = new System.Drawing.Size(186, 20);
            this.txtTitleFilter.TabIndex = 2;
            this.txtTitleFilter.TextChanged += new System.EventHandler(this.txtTitleFilter_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "BookQuantity";
            // 
            // txtBookQuantity
            // 
            this.txtBookQuantity.Location = new System.Drawing.Point(102, 107);
            this.txtBookQuantity.Name = "txtBookQuantity";
            this.txtBookQuantity.Size = new System.Drawing.Size(131, 20);
            this.txtBookQuantity.TabIndex = 2;
            // 
            // lbTotalQuantity
            // 
            this.lbTotalQuantity.AutoSize = true;
            this.lbTotalQuantity.Location = new System.Drawing.Point(307, 386);
            this.lbTotalQuantity.Name = "lbTotalQuantity";
            this.lbTotalQuantity.Size = new System.Drawing.Size(81, 15);
            this.lbTotalQuantity.TabIndex = 4;
            this.lbTotalQuantity.Text = "Total Quantity";
            // 
            // frmMaintainBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 418);
            this.Controls.Add(this.lbTotalQuantity);
            this.Controls.Add(this.dgvBookList);
            this.Controls.Add(this.txtBookQuantity);
            this.Controls.Add(this.txtBookPrice);
            this.Controls.Add(this.txtBookTitle);
            this.Controls.Add(this.txtTitleFilter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRefresh);
            this.Name = "frmMaintainBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Management ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.TextBox txtBookPrice;
        private System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitleFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBookQuantity;
        private System.Windows.Forms.Label lbTotalQuantity;
    }
}

