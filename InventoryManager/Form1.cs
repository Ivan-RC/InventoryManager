using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace InventoryManager
{
    public partial class Form1 : Form
    {
        public static inventory IM = new inventory();
        public Form1()
        {
            MessageBox.Show("Welcome To My Inventory Manager!");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("inventoryTextFile.txt");
            DataTable table = new DataTable();

            string[] data = sr.ReadLine().Split(' ');
            foreach (string s in data)
            {
                table.Columns.Add();
            }
            string nextLine;
            while ((nextLine = sr.ReadLine()) != null)
            {
                DataRow newRow = table.NewRow();
                string[] str = nextLine.Split();
                for (int i = 0; i < str.Length; i++)
                {
                    newRow[i] = str[i];
                }
                table.Rows.Add(newRow);
            }
            sr.Close();
            dataGridView_inventory.DataSource = table;

        }

        private void btn4_delete_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are you sure you would like to delete this item?", " ", MessageBoxButtons.YesNo);
            switch (choice)
            {
                case DialogResult.Yes:
                    int delete;
                    delete = dataGridView_inventory.CurrentCell.RowIndex;
                    product item = IM.getItemList()[delete];
                    IM.removeItem(item);
                    dataGridView_inventory.DataSource = IM.getItemList();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btn1_addItem_Click(object sender, EventArgs e)
        {
            try
            {
                product item = new product();
                item.prodID = textBox1_ID.Text;
                item.title = textBox2_title.Text;
                item.genre = textBox3_genre.Text;
                item.releaseDate = textBox4_releaseDate.Text;
                item.price = double.Parse(textBox5_price.Text);
                item.stockQnty = int.Parse(textBox6_stockQnty.Text);
                IM.addItem(item);
                dataGridView_inventory.DataSource = IM.getItemList();

                //Writing to file
                StreamWriter outFile = new StreamWriter("inventoryTextFile.txt", true);
                for (int i = 0; i < 1; i++)
                {
                    outFile.WriteLine(item.prodID[i] + ", " + item.title + ", " + item.genre + ", " + item.releaseDate
                        + ", " + item.price + ", " + item.stockQnty);
                }
                outFile.Flush();
                outFile.Close();

                //Text boxes are ready for user to type more info into them
                textBox1_ID.Text = "";
                textBox2_title.Text = "";
                textBox3_genre.Text = "";
                textBox4_releaseDate.Text = "";
                textBox5_price.Text = "";
                textBox6_stockQnty.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please make sure you fill out the text boxes with the appropriate information.");
            }
        }

        private void btn3_restock_Click(object sender, EventArgs e)
        {
            try
            {
                int item = dataGridView_inventory.CurrentCell.RowIndex;
                int amount = int.Parse(textBox10_restockAmount.Text);
                product restockItem = IM.getItemList()[item];
                IM.restockItem(amount, restockItem);
                dataGridView_inventory.DataSource = IM.getItemList();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please be sure to enter a number.");
            }

        }

        private void btn2_search_Click(object sender, EventArgs e)
        {
            try
            {
                string searchID = textBox7_searchID.Text;
                MessageBox.Show("Item with id '" + IM.findByID(searchID).prodID + "' found. Item info: " + IM.findByID(searchID) + ".");

                string searchGenre = textBox8_searchGenre.Text;
                MessageBox.Show(IM.findByGenre(searchGenre).genre + " movie found. Item info: " + IM.findByGenre(searchGenre) + ".");

                string searchPrice = textBox9_searchPrice.Text;
                MessageBox.Show("$" + IM.findByPrice(double.Parse(searchPrice)).price + " movie found. Item info: " + IM.findByPrice(double.Parse(searchPrice)) + ".");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Please make sure to fill out the text boxes with the appropriate information.");
            }
        }
    }
}
