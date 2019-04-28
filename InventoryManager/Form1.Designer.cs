namespace InventoryManager
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
            this.btn1_addItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1_ID = new System.Windows.Forms.TextBox();
            this.textBox2_title = new System.Windows.Forms.TextBox();
            this.textBox3_genre = new System.Windows.Forms.TextBox();
            this.textBox4_releaseDate = new System.Windows.Forms.TextBox();
            this.textBox5_price = new System.Windows.Forms.TextBox();
            this.textBox6_stockQnty = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox10_restockAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn3_restock = new System.Windows.Forms.Button();
            this.btn4_delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn2_search = new System.Windows.Forms.Button();
            this.textBox9_searchPrice = new System.Windows.Forms.TextBox();
            this.textBox8_searchGenre = new System.Windows.Forms.TextBox();
            this.textBox7_searchID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView_inventory = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_inventory)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1_addItem
            // 
            this.btn1_addItem.Location = new System.Drawing.Point(219, 212);
            this.btn1_addItem.Name = "btn1_addItem";
            this.btn1_addItem.Size = new System.Drawing.Size(90, 35);
            this.btn1_addItem.TabIndex = 0;
            this.btn1_addItem.Text = "Add Item";
            this.btn1_addItem.UseVisualStyleBackColor = true;
            this.btn1_addItem.Click += new System.EventHandler(this.btn1_addItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Release Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Stock Quantity";
            // 
            // textBox1_ID
            // 
            this.textBox1_ID.Location = new System.Drawing.Point(279, 39);
            this.textBox1_ID.Name = "textBox1_ID";
            this.textBox1_ID.Size = new System.Drawing.Size(100, 22);
            this.textBox1_ID.TabIndex = 7;
            // 
            // textBox2_title
            // 
            this.textBox2_title.Location = new System.Drawing.Point(279, 68);
            this.textBox2_title.Name = "textBox2_title";
            this.textBox2_title.Size = new System.Drawing.Size(100, 22);
            this.textBox2_title.TabIndex = 8;
            // 
            // textBox3_genre
            // 
            this.textBox3_genre.Location = new System.Drawing.Point(279, 97);
            this.textBox3_genre.Name = "textBox3_genre";
            this.textBox3_genre.Size = new System.Drawing.Size(100, 22);
            this.textBox3_genre.TabIndex = 9;
            // 
            // textBox4_releaseDate
            // 
            this.textBox4_releaseDate.Location = new System.Drawing.Point(279, 126);
            this.textBox4_releaseDate.Name = "textBox4_releaseDate";
            this.textBox4_releaseDate.Size = new System.Drawing.Size(100, 22);
            this.textBox4_releaseDate.TabIndex = 10;
            // 
            // textBox5_price
            // 
            this.textBox5_price.Location = new System.Drawing.Point(279, 155);
            this.textBox5_price.Name = "textBox5_price";
            this.textBox5_price.Size = new System.Drawing.Size(100, 22);
            this.textBox5_price.TabIndex = 11;
            // 
            // textBox6_stockQnty
            // 
            this.textBox6_stockQnty.Location = new System.Drawing.Point(279, 184);
            this.textBox6_stockQnty.Name = "textBox6_stockQnty";
            this.textBox6_stockQnty.Size = new System.Drawing.Size(100, 22);
            this.textBox6_stockQnty.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1088, 657);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox6_stockQnty);
            this.tabPage1.Controls.Add(this.btn1_addItem);
            this.tabPage1.Controls.Add(this.textBox5_price);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox4_releaseDate);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox3_genre);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox2_title);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBox1_ID);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1080, 628);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.btn4_delete);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.dataGridView_inventory);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1080, 628);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox10_restockAmount);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btn3_restock);
            this.groupBox2.Location = new System.Drawing.Point(321, 403);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 219);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restock An Item";
            // 
            // textBox10_restockAmount
            // 
            this.textBox10_restockAmount.Location = new System.Drawing.Point(6, 49);
            this.textBox10_restockAmount.Name = "textBox10_restockAmount";
            this.textBox10_restockAmount.Size = new System.Drawing.Size(100, 22);
            this.textBox10_restockAmount.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Amount";
            // 
            // btn3_restock
            // 
            this.btn3_restock.Location = new System.Drawing.Point(187, 172);
            this.btn3_restock.Name = "btn3_restock";
            this.btn3_restock.Size = new System.Drawing.Size(88, 41);
            this.btn3_restock.TabIndex = 15;
            this.btn3_restock.Text = "Restock";
            this.btn3_restock.UseVisualStyleBackColor = true;
            this.btn3_restock.Click += new System.EventHandler(this.btn3_restock_Click);
            // 
            // btn4_delete
            // 
            this.btn4_delete.Location = new System.Drawing.Point(986, 370);
            this.btn4_delete.Name = "btn4_delete";
            this.btn4_delete.Size = new System.Drawing.Size(88, 41);
            this.btn4_delete.TabIndex = 16;
            this.btn4_delete.Text = "Delete";
            this.btn4_delete.UseVisualStyleBackColor = true;
            this.btn4_delete.Click += new System.EventHandler(this.btn4_delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn2_search);
            this.groupBox1.Controls.Add(this.textBox9_searchPrice);
            this.groupBox1.Controls.Add(this.textBox8_searchGenre);
            this.groupBox1.Controls.Add(this.textBox7_searchID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(6, 403);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 219);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search For An Item";
            // 
            // btn2_search
            // 
            this.btn2_search.Location = new System.Drawing.Point(187, 172);
            this.btn2_search.Name = "btn2_search";
            this.btn2_search.Size = new System.Drawing.Size(88, 41);
            this.btn2_search.TabIndex = 14;
            this.btn2_search.Text = "Search";
            this.btn2_search.UseVisualStyleBackColor = true;
            this.btn2_search.Click += new System.EventHandler(this.btn2_search_Click);
            // 
            // textBox9_searchPrice
            // 
            this.textBox9_searchPrice.Location = new System.Drawing.Point(9, 172);
            this.textBox9_searchPrice.Name = "textBox9_searchPrice";
            this.textBox9_searchPrice.Size = new System.Drawing.Size(100, 22);
            this.textBox9_searchPrice.TabIndex = 5;
            // 
            // textBox8_searchGenre
            // 
            this.textBox8_searchGenre.Location = new System.Drawing.Point(9, 110);
            this.textBox8_searchGenre.Name = "textBox8_searchGenre";
            this.textBox8_searchGenre.Size = new System.Drawing.Size(100, 22);
            this.textBox8_searchGenre.TabIndex = 4;
            // 
            // textBox7_searchID
            // 
            this.textBox7_searchID.Location = new System.Drawing.Point(9, 49);
            this.textBox7_searchID.Name = "textBox7_searchID";
            this.textBox7_searchID.Size = new System.Drawing.Size(100, 22);
            this.textBox7_searchID.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Genre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID";
            // 
            // dataGridView_inventory
            // 
            this.dataGridView_inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_inventory.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_inventory.Name = "dataGridView_inventory";
            this.dataGridView_inventory.RowTemplate.Height = 24;
            this.dataGridView_inventory.Size = new System.Drawing.Size(1068, 358);
            this.dataGridView_inventory.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 671);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Inventory Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_inventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1_addItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1_ID;
        private System.Windows.Forms.TextBox textBox2_title;
        private System.Windows.Forms.TextBox textBox3_genre;
        private System.Windows.Forms.TextBox textBox4_releaseDate;
        private System.Windows.Forms.TextBox textBox5_price;
        private System.Windows.Forms.TextBox textBox6_stockQnty;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView_inventory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox9_searchPrice;
        private System.Windows.Forms.TextBox textBox8_searchGenre;
        private System.Windows.Forms.TextBox textBox7_searchID;
        private System.Windows.Forms.Button btn2_search;
        private System.Windows.Forms.Button btn3_restock;
        private System.Windows.Forms.Button btn4_delete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox10_restockAmount;
        private System.Windows.Forms.Label label10;
    }
}

