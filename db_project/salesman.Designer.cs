namespace db_project
{
    partial class salesman
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ProdID_search = new System.Windows.Forms.TextBox();
            this.ProdName_search = new System.Windows.Forms.TextBox();
            this.custID = new System.Windows.Forms.TextBox();
            this.Total_textbox = new System.Windows.Forms.TextBox();
            this.prodQuantity = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.InvID = new System.Windows.Forms.TextBox();
            this.del_btn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.salesmanName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.salesmanID = new System.Windows.Forms.TextBox();
            this.print_btn = new System.Windows.Forms.Button();
            this.product = new System.Windows.Forms.TabControl();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.product.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-166, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 71);
            this.panel1.TabIndex = 12;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.RosyBrown;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(1273, 9);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(34, 25);
            this.button6.TabIndex = 15;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RosyBrown;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(1314, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(34, 25);
            this.button5.TabIndex = 14;
            this.button5.Text = "*";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RosyBrown;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1355, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 25);
            this.button4.TabIndex = 13;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.print_btn);
            this.tabPage2.Controls.Add(this.salesmanID);
            this.tabPage2.Controls.Add(this.salesmanName);
            this.tabPage2.Controls.Add(this.InvID);
            this.tabPage2.Controls.Add(this.prodQuantity);
            this.tabPage2.Controls.Add(this.Total_textbox);
            this.tabPage2.Controls.Add(this.custID);
            this.tabPage2.Controls.Add(this.ProdName_search);
            this.tabPage2.Controls.Add(this.ProdID_search);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.del_btn);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.save_btn);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.add_btn);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.date);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1492, 861);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Receipt";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 108);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.Size = new System.Drawing.Size(504, 437);
            this.dataGridView3.TabIndex = 29;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1,
            this.column2,
            this.Column3,
            this.Column4});
            this.dataGridView2.Location = new System.Drawing.Point(565, 108);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(651, 437);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Unit Price";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // column2
            // 
            this.column2.HeaderText = "Prod_Name";
            this.column2.MinimumWidth = 8;
            this.column2.Name = "column2";
            this.column2.Width = 160;
            // 
            // column1
            // 
            this.column1.HeaderText = "Prod_ID";
            this.column1.MinimumWidth = 8;
            this.column1.Name = "column1";
            this.column1.Width = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Product ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(572, 583);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 28);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1124, 496);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "ThankYou";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "Product Name";
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(1114, 34);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(101, 29);
            this.date.TabIndex = 8;
            this.date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RosyBrown;
            this.button3.Location = new System.Drawing.Point(8, 569);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 57);
            this.button3.TabIndex = 12;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(570, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 21);
            this.label11.TabIndex = 13;
            this.label11.Text = "Customer ID";
            this.label11.Click += new System.EventHandler(this.label11_Click_1);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.RosyBrown;
            this.add_btn.Location = new System.Drawing.Point(377, 569);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(133, 57);
            this.add_btn.TabIndex = 26;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(210, 587);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 21);
            this.label9.TabIndex = 27;
            this.label9.Text = "Quantity";
            // 
            // ProdID_search
            // 
            this.ProdID_search.Location = new System.Drawing.Point(126, 11);
            this.ProdID_search.Multiline = true;
            this.ProdID_search.Name = "ProdID_search";
            this.ProdID_search.Size = new System.Drawing.Size(172, 21);
            this.ProdID_search.TabIndex = 1;
            this.ProdID_search.TextChanged += new System.EventHandler(this.ProdID_search_TextChanged);
            // 
            // ProdName_search
            // 
            this.ProdName_search.Location = new System.Drawing.Point(126, 52);
            this.ProdName_search.Multiline = true;
            this.ProdName_search.Name = "ProdName_search";
            this.ProdName_search.Size = new System.Drawing.Size(172, 21);
            this.ProdName_search.TabIndex = 6;
            this.ProdName_search.TextChanged += new System.EventHandler(this.ProdName_search_TextChanged);
            // 
            // custID
            // 
            this.custID.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custID.Location = new System.Drawing.Point(683, 16);
            this.custID.Multiline = true;
            this.custID.Name = "custID";
            this.custID.Size = new System.Drawing.Size(122, 24);
            this.custID.TabIndex = 16;
            this.custID.TextChanged += new System.EventHandler(this.custID_TextChanged);
            // 
            // Total_textbox
            // 
            this.Total_textbox.Enabled = false;
            this.Total_textbox.Location = new System.Drawing.Point(651, 583);
            this.Total_textbox.Multiline = true;
            this.Total_textbox.Name = "Total_textbox";
            this.Total_textbox.Size = new System.Drawing.Size(104, 29);
            this.Total_textbox.TabIndex = 25;
            this.Total_textbox.Text = "0";
            this.Total_textbox.TextChanged += new System.EventHandler(this.Total_textbox_TextChanged);
            // 
            // prodQuantity
            // 
            this.prodQuantity.Location = new System.Drawing.Point(292, 583);
            this.prodQuantity.Multiline = true;
            this.prodQuantity.Name = "prodQuantity";
            this.prodQuantity.Size = new System.Drawing.Size(49, 29);
            this.prodQuantity.TabIndex = 28;
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.RosyBrown;
            this.save_btn.Location = new System.Drawing.Point(904, 569);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(133, 57);
            this.save_btn.TabIndex = 30;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(856, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 21);
            this.label10.TabIndex = 31;
            this.label10.Text = "Invoice ID";
            this.label10.Click += new System.EventHandler(this.label10_Click_1);
            // 
            // InvID
            // 
            this.InvID.Enabled = false;
            this.InvID.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvID.Location = new System.Drawing.Point(980, 17);
            this.InvID.Multiline = true;
            this.InvID.Name = "InvID";
            this.InvID.Size = new System.Drawing.Size(122, 22);
            this.InvID.TabIndex = 32;
            this.InvID.TextChanged += new System.EventHandler(this.InvID_TextChanged);
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.Color.RosyBrown;
            this.del_btn.Location = new System.Drawing.Point(797, 569);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(100, 57);
            this.del_btn.TabIndex = 33;
            this.del_btn.Text = "Delete";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(856, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 21);
            this.label12.TabIndex = 34;
            this.label12.Text = "Salesman Name";
            // 
            // salesmanName
            // 
            this.salesmanName.Enabled = false;
            this.salesmanName.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesmanName.Location = new System.Drawing.Point(980, 60);
            this.salesmanName.Multiline = true;
            this.salesmanName.Name = "salesmanName";
            this.salesmanName.Size = new System.Drawing.Size(122, 24);
            this.salesmanName.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(570, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 21);
            this.label13.TabIndex = 36;
            this.label13.Text = "Salesman ID";
            // 
            // salesmanID
            // 
            this.salesmanID.Enabled = false;
            this.salesmanID.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesmanID.Location = new System.Drawing.Point(683, 60);
            this.salesmanID.Multiline = true;
            this.salesmanID.Name = "salesmanID";
            this.salesmanID.Size = new System.Drawing.Size(122, 24);
            this.salesmanID.TabIndex = 37;
            // 
            // print_btn
            // 
            this.print_btn.BackColor = System.Drawing.Color.RosyBrown;
            this.print_btn.Location = new System.Drawing.Point(1062, 569);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(156, 57);
            this.print_btn.TabIndex = 38;
            this.print_btn.Text = "Print";
            this.print_btn.UseVisualStyleBackColor = false;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // product
            // 
            this.product.Controls.Add(this.tabPage2);
            this.product.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.Location = new System.Drawing.Point(0, 71);
            this.product.Name = "product";
            this.product.Padding = new System.Drawing.Point(10, 5);
            this.product.SelectedIndex = 0;
            this.product.Size = new System.Drawing.Size(1500, 900);
            this.product.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(660, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Shop Management System";
            // 
            // salesman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1234, 741);
            this.Controls.Add(this.product);
            this.Controls.Add(this.panel1);
            this.Name = "salesman";
            this.Text = "Sales Portal";
            this.Load += new System.EventHandler(this.salesman_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.product.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.TextBox salesmanID;
        private System.Windows.Forms.TextBox salesmanName;
        private System.Windows.Forms.TextBox InvID;
        private System.Windows.Forms.TextBox prodQuantity;
        private System.Windows.Forms.TextBox Total_textbox;
        private System.Windows.Forms.TextBox custID;
        private System.Windows.Forms.TextBox ProdName_search;
        private System.Windows.Forms.TextBox ProdID_search;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabControl product;
        private System.Windows.Forms.Label label2;
    }
}