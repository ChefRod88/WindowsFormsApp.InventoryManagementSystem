﻿namespace WindowsFormsApp.InventoryManagementSystem
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
            this.btn_Parts_Delete = new System.Windows.Forms.Button();
            this.btn_Products_Add = new System.Windows.Forms.Button();
            this.btn_Products_Modify = new System.Windows.Forms.Button();
            this.btn_Products_Delete = new System.Windows.Forms.Button();
            this.btn_Parts_Add = new System.Windows.Forms.Button();
            this.btn_Parts_Modify = new System.Windows.Forms.Button();
            this.btn_Parts_Search = new System.Windows.Forms.Button();
            this.txtSearchParts = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSearchProducts = new System.Windows.Forms.TextBox();
            this.btn_Products_Search = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management System";
            // 
            // dgvParts
            // 
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Location = new System.Drawing.Point(17, 175);
            this.dgvParts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.RowHeadersWidth = 51;
            this.dgvParts.Size = new System.Drawing.Size(450, 270);
            this.dgvParts.TabIndex = 1;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(640, 175);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.Size = new System.Drawing.Size(512, 270);
            this.dgvProducts.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parts";
            // 
            // btn_Parts_Delete
            // 
            this.btn_Parts_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Parts_Delete.Location = new System.Drawing.Point(379, 476);
            this.btn_Parts_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Parts_Delete.Name = "btn_Parts_Delete";
            this.btn_Parts_Delete.Size = new System.Drawing.Size(88, 42);
            this.btn_Parts_Delete.TabIndex = 5;
            this.btn_Parts_Delete.Text = "Delete";
            this.btn_Parts_Delete.UseVisualStyleBackColor = true;
            this.btn_Parts_Delete.Click += new System.EventHandler(this.btn_Parts_Delete_Click);
            // 
            // btn_Products_Add
            // 
            this.btn_Products_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Products_Add.Location = new System.Drawing.Point(803, 476);
            this.btn_Products_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Products_Add.Name = "btn_Products_Add";
            this.btn_Products_Add.Size = new System.Drawing.Size(115, 42);
            this.btn_Products_Add.TabIndex = 6;
            this.btn_Products_Add.Text = "Add";
            this.btn_Products_Add.UseVisualStyleBackColor = true;
            this.btn_Products_Add.Click += new System.EventHandler(this.btn_Products_Add_Click);
            // 
            // btn_Products_Modify
            // 
            this.btn_Products_Modify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Products_Modify.Location = new System.Drawing.Point(944, 476);
            this.btn_Products_Modify.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Products_Modify.Name = "btn_Products_Modify";
            this.btn_Products_Modify.Size = new System.Drawing.Size(100, 42);
            this.btn_Products_Modify.TabIndex = 7;
            this.btn_Products_Modify.Text = "Modify";
            this.btn_Products_Modify.UseVisualStyleBackColor = true;
            this.btn_Products_Modify.Click += new System.EventHandler(this.btn_Products_Modify_Click);
            // 
            // btn_Products_Delete
            // 
            this.btn_Products_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Products_Delete.Location = new System.Drawing.Point(1067, 476);
            this.btn_Products_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Products_Delete.Name = "btn_Products_Delete";
            this.btn_Products_Delete.Size = new System.Drawing.Size(83, 42);
            this.btn_Products_Delete.TabIndex = 8;
            this.btn_Products_Delete.Text = "Delete";
            this.btn_Products_Delete.UseVisualStyleBackColor = true;
            this.btn_Products_Delete.Click += new System.EventHandler(this.btn_Products_Delete_Click);
            // 
            // btn_Parts_Add
            // 
            this.btn_Parts_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Parts_Add.Location = new System.Drawing.Point(148, 476);
            this.btn_Parts_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Parts_Add.Name = "btn_Parts_Add";
            this.btn_Parts_Add.Size = new System.Drawing.Size(84, 42);
            this.btn_Parts_Add.TabIndex = 9;
            this.btn_Parts_Add.Text = "Add";
            this.btn_Parts_Add.UseVisualStyleBackColor = true;
            this.btn_Parts_Add.Click += new System.EventHandler(this.btn_Parts_Add_Click);
            // 
            // btn_Parts_Modify
            // 
            this.btn_Parts_Modify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Parts_Modify.Location = new System.Drawing.Point(262, 476);
            this.btn_Parts_Modify.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Parts_Modify.Name = "btn_Parts_Modify";
            this.btn_Parts_Modify.Size = new System.Drawing.Size(86, 42);
            this.btn_Parts_Modify.TabIndex = 10;
            this.btn_Parts_Modify.Text = "Modify";
            this.btn_Parts_Modify.UseVisualStyleBackColor = true;
            this.btn_Parts_Modify.Click += new System.EventHandler(this.btn_Parts_Modify_Click);
            // 
            // btn_Parts_Search
            // 
            this.btn_Parts_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Parts_Search.Location = new System.Drawing.Point(131, 134);
            this.btn_Parts_Search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Parts_Search.Name = "btn_Parts_Search";
            this.btn_Parts_Search.Size = new System.Drawing.Size(101, 24);
            this.btn_Parts_Search.TabIndex = 11;
            this.btn_Parts_Search.Text = "Search";
            this.btn_Parts_Search.UseVisualStyleBackColor = true;
            this.btn_Parts_Search.Click += new System.EventHandler(this.btn_Parts_Search_Click);
            // 
            // txtSearchParts
            // 
            this.txtSearchParts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchParts.Location = new System.Drawing.Point(262, 137);
            this.txtSearchParts.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchParts.Name = "txtSearchParts";
            this.txtSearchParts.Size = new System.Drawing.Size(205, 22);
            this.txtSearchParts.TabIndex = 13;
            this.txtSearchParts.TextChanged += new System.EventHandler(this.txtSearchParts_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(1793, 1141);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(197, 63);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSearchProducts
            // 
            this.txtSearchProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchProducts.Location = new System.Drawing.Point(944, 136);
            this.txtSearchProducts.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchProducts.Name = "txtSearchProducts";
            this.txtSearchProducts.Size = new System.Drawing.Size(208, 22);
            this.txtSearchProducts.TabIndex = 18;
            // 
            // btn_Products_Search
            // 
            this.btn_Products_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Products_Search.Location = new System.Drawing.Point(803, 134);
            this.btn_Products_Search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Products_Search.Name = "btn_Products_Search";
            this.btn_Products_Search.Size = new System.Drawing.Size(101, 24);
            this.btn_Products_Search.TabIndex = 17;
            this.btn_Products_Search.Text = "Search";
            this.btn_Products_Search.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(631, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "Products";
            // 
            // buttonexit
            // 
            this.buttonexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonexit.Location = new System.Drawing.Point(1067, 538);
            this.buttonexit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(83, 42);
            this.buttonexit.TabIndex = 19;
            this.buttonexit.Text = "Exit";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // formMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 609);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.txtSearchProducts);
            this.Controls.Add(this.btn_Products_Search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtSearchParts);
            this.Controls.Add(this.btn_Parts_Search);
            this.Controls.Add(this.btn_Parts_Modify);
            this.Controls.Add(this.btn_Parts_Add);
            this.Controls.Add(this.btn_Products_Delete);
            this.Controls.Add(this.btn_Products_Modify);
            this.Controls.Add(this.btn_Products_Add);
            this.Controls.Add(this.btn_Parts_Delete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dgvParts);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btn_Parts_Delete;
        private System.Windows.Forms.Button btn_Products_Add;
        private System.Windows.Forms.Button btn_Products_Modify;
        private System.Windows.Forms.Button btn_Products_Delete;
        private System.Windows.Forms.Button btn_Parts_Add;
        private System.Windows.Forms.Button btn_Parts_Modify;
        private System.Windows.Forms.Button btn_Parts_Search;
        private System.Windows.Forms.TextBox txtSearchParts;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSearchProducts;
        private System.Windows.Forms.Button btn_Products_Search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonexit;
    }
}