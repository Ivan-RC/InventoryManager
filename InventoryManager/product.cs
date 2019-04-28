using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    public class Product
    {
        public string prodID { set; get; }
        public string title { set; get; }
        public string genre { set; get; }
        public string releaseDate { set; get; }
        public double price { set; get; }
        public int stockQnty { set; get; }

        public Product()
        {
            prodID = "";
            title = "";
            genre = "";
            releaseDate = "";
            price = 0.0;
            stockQnty = 0;
        }
        public override string ToString()
        {
            return "Product ID: " + prodID + ", Title: " + title + ", Genre: " + genre + ", Release Date: " + releaseDate
                + ", Price: $" + price + ", Stock Quantity: " + stockQnty;
        }

    }
}
