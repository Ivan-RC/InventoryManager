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
        public static Inventory IM = new Inventory();
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Welcome To My Inventory Manager!");                
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Read from file and insert into datagridview
            StreamReader sr = new StreamReader("inventoryTextFile.txt");
            string[] data = sr.ReadLine().Split(' ');
            DataTable table = new DataTable();
            foreach (string s in data)
            {
                table.Columns.Add();
            }
            string nextLine;
            while ((nextLine = sr.ReadLine()) != null)
            {
                DataRow newRow = table.NewRow();
                string[] str = nextLine.Split(' ');
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
            try
            {
                //Choice to cancel or accept item deletion
                DialogResult choice = MessageBox.Show("Are you sure you would like to delete this item?", " ", MessageBoxButtons.YesNo);
                switch (choice)
                {
                    case DialogResult.Yes:
                        int delete;
                        delete = dataGridView_inventory.CurrentCell.RowIndex;
                        Product item = IM.getItemList()[delete];
                        IM.removeItem(item);
                        dataGridView_inventory.DataSource = IM.getItemList();
                        break;
                    case DialogResult.No:
                        break;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Please make sure that you've selected an item to delete.");
            }
        }

        private void btn1_addItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                //Adding a new item to the data grid view
                Product item = new Product();
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
                    outFile.WriteLine(item.prodID + ", " + item.title + ", " + item.genre + ", " + item.releaseDate
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
                //Restock any item that you'd like
                int item = dataGridView_inventory.CurrentCell.RowIndex;
                int amount = int.Parse(textBox10_restockAmount.Text);
                Product restockItem = IM.getItemList()[item];
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
                //Substitution for search, hopefully i figure out how to properly search
                string searchID = textBox7_searchID.Text;
                MessageBox.Show("Item with id '" + IM.findByID(searchID).prodID + "' found. Item info: " + IM.findByID(searchID) + ".");

                string searchGenre = textBox8_searchGenre.Text;
                MessageBox.Show(IM.findByGenre(searchGenre).genre + " movie found. Item info: " + IM.findByGenre(searchGenre) + ".");

                string searchPrice = textBox9_searchPrice.Text;
                MessageBox.Show("$" + IM.findByPrice(double.Parse(searchPrice)).price + " movie found. Item info: " + IM.findByPrice(double.Parse(searchPrice)) + ".");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please make sure to fill out the text boxes with the appropriate information.");
            }
        }
    }
}
