namespace WindowsFormsApp.InventoryManagementSystem
{
    partial class formMainScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Parts_Delete = new System.Windows.Forms.Button();
            this.btn_Products_Add = new System.Windows.Forms.Button();
            this.btn_Products_Modify = new System.Windows.Forms.Button();
            this.btn_Products_Delete = new System.Windows.Forms.Button();
            this.btn_Parts_Add = new System.Windows.Forms.Button();
            this.btn_Parts_Modify = new System.Windows.Forms.Button();
            this.btn_Parts_Search = new System.Windows.Forms.Button();
            this.btn_Products_Search = new System.Windows.Forms.Button();
            this.txtSearchParts = new System.Windows.Forms.TextBox();
            this.txtSearchProducts = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management System";
            // 
            // dgvParts
            // 
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Location = new System.Drawing.Point(14, 233);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.RowHeadersWidth = 51;
            this.dgvParts.Size = new System.Drawing.Size(704, 424);
            this.dgvParts.TabIndex = 1;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(789, 233);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.Size = new System.Drawing.Size(704, 424);
            this.dgvProducts.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(783, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Products";
            // 
            // btn_Parts_Delete
            // 
            this.btn_Parts_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Parts_Delete.Location = new System.Drawing.Point(570, 668);
            this.btn_Parts_Delete.Name = "btn_Parts_Delete";
            this.btn_Parts_Delete.Size = new System.Drawing.Size(148, 51);
            this.btn_Parts_Delete.TabIndex = 5;
            this.btn_Parts_Delete.Text = "Delete";
            this.btn_Parts_Delete.UseVisualStyleBackColor = true;
            this.btn_Parts_Delete.Click += new System.EventHandler(this.btn_Parts_Delete_Click);
            // 
            // btn_Products_Add
            // 
            this.btn_Products_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Products_Add.Location = new System.Drawing.Point(1037, 668);
            this.btn_Products_Add.Name = "btn_Products_Add";
            this.btn_Products_Add.Size = new System.Drawing.Size(148, 51);
            this.btn_Products_Add.TabIndex = 6;
            this.btn_Products_Add.Text = "Add";
            this.btn_Products_Add.UseVisualStyleBackColor = true;
            this.btn_Products_Add.Click += new System.EventHandler(this.btn_Products_Add_Click);
            // 
            // btn_Products_Modify
            // 
            this.btn_Products_Modify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Products_Modify.Location = new System.Drawing.Point(1191, 668);
            this.btn_Products_Modify.Name = "btn_Products_Modify";
            this.btn_Products_Modify.Size = new System.Drawing.Size(148, 51);
            this.btn_Products_Modify.TabIndex = 7;
            this.btn_Products_Modify.Text = "Modify";
            this.btn_Products_Modify.UseVisualStyleBackColor = true;
            this.btn_Products_Modify.Click += new System.EventHandler(this.btn_Products_Modify_Click);
            // 
            // btn_Products_Delete
            // 
            this.btn_Products_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Products_Delete.Location = new System.Drawing.Point(1345, 668);
            this.btn_Products_Delete.Name = "btn_Products_Delete";
            this.btn_Products_Delete.Size = new System.Drawing.Size(148, 51);
            this.btn_Products_Delete.TabIndex = 8;
            this.btn_Products_Delete.Text = "Delete";
            this.btn_Products_Delete.UseVisualStyleBackColor = true;
            this.btn_Products_Delete.Click += new System.EventHandler(this.btn_Products_Delete_Click);
            // 
            // btn_Parts_Add
            // 
            this.btn_Parts_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Parts_Add.Location = new System.Drawing.Point(264, 668);
            this.btn_Parts_Add.Name = "btn_Parts_Add";
            this.btn_Parts_Add.Size = new System.Drawing.Size(148, 51);
            this.btn_Parts_Add.TabIndex = 9;
            this.btn_Parts_Add.Text = "Add";
            this.btn_Parts_Add.UseVisualStyleBackColor = true;
            this.btn_Parts_Add.Click += new System.EventHandler(this.btn_Parts_Add_Click);
            // 
            // btn_Parts_Modify
            // 
            this.btn_Parts_Modify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Parts_Modify.Location = new System.Drawing.Point(416, 668);
            this.btn_Parts_Modify.Name = "btn_Parts_Modify";
            this.btn_Parts_Modify.Size = new System.Drawing.Size(148, 51);
            this.btn_Parts_Modify.TabIndex = 10;
            this.btn_Parts_Modify.Text = "Modify";
            this.btn_Parts_Modify.UseVisualStyleBackColor = true;
            this.btn_Parts_Modify.Click += new System.EventHandler(this.btn_Parts_Modify_Click);
            // 
            // btn_Parts_Search
            // 
            this.btn_Parts_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Parts_Search.Location = new System.Drawing.Point(336, 175);
            this.btn_Parts_Search.Name = "btn_Parts_Search";
            this.btn_Parts_Search.Size = new System.Drawing.Size(100, 30);
            this.btn_Parts_Search.TabIndex = 11;
            this.btn_Parts_Search.Text = "Search";
            this.btn_Parts_Search.UseVisualStyleBackColor = true;
            this.btn_Parts_Search.Click += new System.EventHandler(this.btn_Parts_Search_Click);
            // 
            // btn_Products_Search
            // 
            this.btn_Products_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Products_Search.Location = new System.Drawing.Point(1114, 175);
            this.btn_Products_Search.Name = "btn_Products_Search";
            this.btn_Products_Search.Size = new System.Drawing.Size(100, 30);
            this.btn_Products_Search.TabIndex = 12;
            this.btn_Products_Search.Text = "Search";
            this.btn_Products_Search.UseVisualStyleBackColor = true;
            this.btn_Products_Search.Click += new System.EventHandler(this.btn_Products_Search_Click);
            // 
            // txtSearchParts
            // 
            this.txtSearchParts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchParts.Location = new System.Drawing.Point(445, 181);
            this.txtSearchParts.Name = "txtSearchParts";
            this.txtSearchParts.Size = new System.Drawing.Size(273, 20);
            this.txtSearchParts.TabIndex = 13;
            // 
            // txtSearchProducts
            // 
            this.txtSearchProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchProducts.Location = new System.Drawing.Point(1220, 181);
            this.txtSearchProducts.Name = "txtSearchProducts";
            this.txtSearchProducts.Size = new System.Drawing.Size(273, 20);
            this.txtSearchProducts.TabIndex = 14;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(1345, 927);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 51);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // formMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 1005);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtSearchProducts);
            this.Controls.Add(this.txtSearchParts);
            this.Controls.Add(this.btn_Products_Search);
            this.Controls.Add(this.btn_Parts_Search);
            this.Controls.Add(this.btn_Parts_Modify);
            this.Controls.Add(this.btn_Parts_Add);
            this.Controls.Add(this.btn_Products_Delete);
            this.Controls.Add(this.btn_Products_Modify);
            this.Controls.Add(this.btn_Products_Add);
            this.Controls.Add(this.btn_Parts_Delete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dgvParts);
            this.Controls.Add(this.label1);
            this.Name = "formMainScreen";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Parts_Delete;
        private System.Windows.Forms.Button btn_Products_Add;
        private System.Windows.Forms.Button btn_Products_Modify;
        private System.Windows.Forms.Button btn_Products_Delete;
        private System.Windows.Forms.Button btn_Parts_Add;
        private System.Windows.Forms.Button btn_Parts_Modify;
        private System.Windows.Forms.Button btn_Parts_Search;
        private System.Windows.Forms.Button btn_Products_Search;
        private System.Windows.Forms.TextBox txtSearchParts;
        private System.Windows.Forms.TextBox txtSearchProducts;
        private System.Windows.Forms.Button btnExit;
    }
}