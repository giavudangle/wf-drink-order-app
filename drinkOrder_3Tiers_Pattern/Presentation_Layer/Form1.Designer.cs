﻿namespace drinkOrder_3Tiers_Pattern
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_productID = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_status = new System.Windows.Forms.TextBox();
            this.listDataDrink = new System.Windows.Forms.DataGridView();
            this.listOrder = new System.Windows.Forms.DataGridView();
            this.numberic_Quantity = new System.Windows.Forms.NumericUpDown();
            this.numeric_Sale = new System.Windows.Forms.NumericUpDown();
            this.cbx_DrinkName = new System.Windows.Forms.ComboBox();
            this.txt_orderID = new System.Windows.Forms.TextBox();
            this.labelORDER = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_AddOrder = new System.Windows.Forms.Button();
            this.btn_Calculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listDataDrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberic_Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Sale)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.AutoSize = true;
            this.btnAdd.Location = new System.Drawing.Point(12, 523);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 51);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD DRINK";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnEdit.AutoSize = true;
            this.btnEdit.Location = new System.Drawing.Point(403, 523);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(163, 51);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "EDIT DRINK";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnDelete.AutoSize = true;
            this.btnDelete.Location = new System.Drawing.Point(203, 523);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(159, 51);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "DELETE DRINK";
            this.btnDelete.UseCompatibleTextRendering = true;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status";
            // 
            // textBox_productID
            // 
            this.textBox_productID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_productID.Location = new System.Drawing.Point(12, 23);
            this.textBox_productID.Name = "textBox_productID";
            this.textBox_productID.Size = new System.Drawing.Size(73, 20);
            this.textBox_productID.TabIndex = 9;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Name.Location = new System.Drawing.Point(133, 23);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(169, 20);
            this.textBox_Name.TabIndex = 10;
            // 
            // textBox_price
            // 
            this.textBox_price.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_price.Location = new System.Drawing.Point(344, 23);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(75, 20);
            this.textBox_price.TabIndex = 11;
            // 
            // textBox_status
            // 
            this.textBox_status.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_status.Location = new System.Drawing.Point(458, 23);
            this.textBox_status.Name = "textBox_status";
            this.textBox_status.Size = new System.Drawing.Size(73, 20);
            this.textBox_status.TabIndex = 12;
            // 
            // listDataDrink
            // 
            this.listDataDrink.AllowDrop = true;
            this.listDataDrink.AllowUserToOrderColumns = true;
            this.listDataDrink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listDataDrink.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listDataDrink.BackgroundColor = System.Drawing.SystemColors.Window;
            this.listDataDrink.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.listDataDrink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listDataDrink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listDataDrink.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.listDataDrink.Location = new System.Drawing.Point(12, 49);
            this.listDataDrink.MultiSelect = false;
            this.listDataDrink.Name = "listDataDrink";
            this.listDataDrink.ReadOnly = true;
            this.listDataDrink.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listDataDrink.Size = new System.Drawing.Size(554, 468);
            this.listDataDrink.TabIndex = 13;
            this.listDataDrink.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listDataDrink_CellClick);
            // 
            // listOrder
            // 
            this.listOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.listOrder.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.listOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOrder.Location = new System.Drawing.Point(572, 49);
            this.listOrder.MultiSelect = false;
            this.listOrder.Name = "listOrder";
            this.listOrder.ReadOnly = true;
            this.listOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listOrder.Size = new System.Drawing.Size(493, 468);
            this.listOrder.TabIndex = 14;
            // 
            // numberic_Quantity
            // 
            this.numberic_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numberic_Quantity.Location = new System.Drawing.Point(886, 24);
            this.numberic_Quantity.Name = "numberic_Quantity";
            this.numberic_Quantity.Size = new System.Drawing.Size(80, 20);
            this.numberic_Quantity.TabIndex = 15;
            // 
            // numeric_Sale
            // 
            this.numeric_Sale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numeric_Sale.Location = new System.Drawing.Point(985, 24);
            this.numeric_Sale.Name = "numeric_Sale";
            this.numeric_Sale.Size = new System.Drawing.Size(80, 20);
            this.numeric_Sale.TabIndex = 16;
            // 
            // cbx_DrinkName
            // 
            this.cbx_DrinkName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_DrinkName.FormattingEnabled = true;
            this.cbx_DrinkName.Location = new System.Drawing.Point(714, 22);
            this.cbx_DrinkName.Name = "cbx_DrinkName";
            this.cbx_DrinkName.Size = new System.Drawing.Size(154, 21);
            this.cbx_DrinkName.TabIndex = 17;
            // 
            // txt_orderID
            // 
            this.txt_orderID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_orderID.Location = new System.Drawing.Point(591, 23);
            this.txt_orderID.Name = "txt_orderID";
            this.txt_orderID.Size = new System.Drawing.Size(100, 20);
            this.txt_orderID.TabIndex = 18;
            // 
            // labelORDER
            // 
            this.labelORDER.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelORDER.AutoSize = true;
            this.labelORDER.Location = new System.Drawing.Point(605, 3);
            this.labelORDER.Name = "labelORDER";
            this.labelORDER.Size = new System.Drawing.Size(44, 13);
            this.labelORDER.TabIndex = 19;
            this.labelORDER.Text = "OrderID";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(739, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Drink Name";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(883, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1004, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Sale(%)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_AddOrder
            // 
            this.btn_AddOrder.Location = new System.Drawing.Point(572, 523);
            this.btn_AddOrder.Name = "btn_AddOrder";
            this.btn_AddOrder.Size = new System.Drawing.Size(258, 51);
            this.btn_AddOrder.TabIndex = 23;
            this.btn_AddOrder.Text = "ADD ORDER";
            this.btn_AddOrder.UseVisualStyleBackColor = true;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(836, 523);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(229, 51);
            this.btn_Calculate.TabIndex = 24;
            this.btn_Calculate.Text = "CALCULATE";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1077, 574);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.btn_AddOrder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelORDER);
            this.Controls.Add(this.txt_orderID);
            this.Controls.Add(this.cbx_DrinkName);
            this.Controls.Add(this.numeric_Sale);
            this.Controls.Add(this.numberic_Quantity);
            this.Controls.Add(this.listOrder);
            this.Controls.Add(this.listDataDrink);
            this.Controls.Add(this.textBox_status);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_productID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.listDataDrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberic_Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Sale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_productID;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.DataGridView listDataDrink;
        private System.Windows.Forms.DataGridView listOrder;
        private System.Windows.Forms.NumericUpDown numberic_Quantity;
        private System.Windows.Forms.NumericUpDown numeric_Sale;
        private System.Windows.Forms.ComboBox cbx_DrinkName;
        private System.Windows.Forms.TextBox txt_orderID;
        private System.Windows.Forms.Label labelORDER;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_AddOrder;
        private System.Windows.Forms.Button btn_Calculate;
        public System.Windows.Forms.TextBox textBox_status;
    }
}

