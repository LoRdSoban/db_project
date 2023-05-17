namespace db_project
{
    partial class order
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.ven_name = new System.Windows.Forms.ComboBox();
            this.Total_textbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.purchasePrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.prodName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.prodID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vendorID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.save_btn = new System.Windows.Forms.Button();
            this.OrderID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.ven_name);
            this.panel3.Controls.Add(this.Total_textbox);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.quantity);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.purchasePrice);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.prodName);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.prodID);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.vendorID);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.date);
            this.panel3.Controls.Add(this.save_btn);
            this.panel3.Controls.Add(this.OrderID);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(-3, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1352, 631);
            this.panel3.TabIndex = 41;
            // 
            // ven_name
            // 
            this.ven_name.FormattingEnabled = true;
            this.ven_name.Location = new System.Drawing.Point(348, 275);
            this.ven_name.Name = "ven_name";
            this.ven_name.Size = new System.Drawing.Size(145, 21);
            this.ven_name.TabIndex = 44;
            this.ven_name.DropDownClosed += new System.EventHandler(this.ven_name_DropDownClosed);
            // 
            // Total_textbox
            // 
            this.Total_textbox.BackColor = System.Drawing.Color.Snow;
            this.Total_textbox.Enabled = false;
            this.Total_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_textbox.Location = new System.Drawing.Point(599, 479);
            this.Total_textbox.Name = "Total_textbox";
            this.Total_textbox.Size = new System.Drawing.Size(145, 31);
            this.Total_textbox.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.RosyBrown;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(475, 479);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 32);
            this.label10.TabIndex = 42;
            this.label10.Text = "Total";
            // 
            // quantity
            // 
            this.quantity.BackColor = System.Drawing.Color.Snow;
            this.quantity.Location = new System.Drawing.Point(786, 337);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(145, 20);
            this.quantity.TabIndex = 41;
            this.quantity.TextChanged += new System.EventHandler(this.quantity_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.RosyBrown;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(662, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 22);
            this.label9.TabIndex = 40;
            this.label9.Text = "Quantity";
            // 
            // purchasePrice
            // 
            this.purchasePrice.BackColor = System.Drawing.Color.Snow;
            this.purchasePrice.Enabled = false;
            this.purchasePrice.Location = new System.Drawing.Point(786, 272);
            this.purchasePrice.Name = "purchasePrice";
            this.purchasePrice.Size = new System.Drawing.Size(145, 20);
            this.purchasePrice.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.RosyBrown;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(662, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 22);
            this.label8.TabIndex = 38;
            this.label8.Text = "Purchase Price";
            // 
            // prodName
            // 
            this.prodName.BackColor = System.Drawing.Color.Snow;
            this.prodName.Enabled = false;
            this.prodName.Location = new System.Drawing.Point(786, 207);
            this.prodName.Name = "prodName";
            this.prodName.Size = new System.Drawing.Size(145, 20);
            this.prodName.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RosyBrown;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(662, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 22);
            this.label6.TabIndex = 36;
            this.label6.Text = "Product Name";
            // 
            // prodID
            // 
            this.prodID.BackColor = System.Drawing.Color.Snow;
            this.prodID.Enabled = false;
            this.prodID.Location = new System.Drawing.Point(786, 142);
            this.prodID.Name = "prodID";
            this.prodID.Size = new System.Drawing.Size(145, 20);
            this.prodID.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.RosyBrown;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(662, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 22);
            this.label5.TabIndex = 34;
            this.label5.Text = "Product Id";
            // 
            // vendorID
            // 
            this.vendorID.BackColor = System.Drawing.Color.Snow;
            this.vendorID.Enabled = false;
            this.vendorID.Location = new System.Drawing.Point(348, 207);
            this.vendorID.Name = "vendorID";
            this.vendorID.Size = new System.Drawing.Size(145, 20);
            this.vendorID.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RosyBrown;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 22);
            this.label3.TabIndex = 32;
            this.label3.Text = "Vendor Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "Vendor Id";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(980, 79);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(245, 29);
            this.date.TabIndex = 29;
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.RosyBrown;
            this.save_btn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(574, 569);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(102, 44);
            this.save_btn.TabIndex = 28;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // OrderID
            // 
            this.OrderID.BackColor = System.Drawing.Color.Snow;
            this.OrderID.Enabled = false;
            this.OrderID.Location = new System.Drawing.Point(126, 80);
            this.OrderID.Name = "OrderID";
            this.OrderID.Size = new System.Drawing.Size(145, 20);
            this.OrderID.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.RosyBrown;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "Order Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lavender;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(530, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "Order Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(606, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shop Management System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-101, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1436, 69);
            this.panel1.TabIndex = 40;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.RosyBrown;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(1116, 24);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(34, 25);
            this.button7.TabIndex = 42;
            this.button7.Text = "-";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RosyBrown;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(1156, 24);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(34, 25);
            this.button5.TabIndex = 41;
            this.button5.Text = "*";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.RosyBrown;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(1196, 24);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(34, 25);
            this.button6.TabIndex = 40;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RosyBrown;
            this.button4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(15, 580);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 33);
            this.button4.TabIndex = 45;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 741);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "order";
            this.Text = "Order Product";
            this.Load += new System.EventHandler(this.Order_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox OrderID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Total_textbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox purchasePrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox prodName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox prodID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox vendorID;
        private System.Windows.Forms.ComboBox ven_name;
        private System.Windows.Forms.Button button4;
    }
}