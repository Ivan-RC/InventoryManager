using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    public class Inventory
    {
        public List<Product> items;

        public Inventory()
        {
            //initializing attributes
            items = new List<Product>();
        }

        //Make an array of the items in the manager
        public Product[] getItemArray()
        {
            int index = 0;
            Product[] itemArr = new Product[items.Count];
            foreach (Product item in items)
            {
                Product i = item;
                itemArr[index++] = i;
            }
            return itemArr;
        }

        public List<Product> getItemList()
        {
            List<Product> listIM = new List<Product>();

            foreach (Product i in items)
            {
                Product item = i;
                listIM.Add(i);
            }
            return listIM;
        }

        public bool addItem(Product item)
        {
            if (items.Contains(item))
                return false;
            items.Add(item);
            return true;
        }

        public bool removeItem(Product item)
        {
            //Ability to remove an item from the list
            items.Remove(item);
            return true;
        }

        public bool restockItem(int count, Product item)
        {
            //logic for restocking an item
            for (int i = 0; i < items.Count(); i++)
            {
                if (items[i] == item)
                {
                    items[i].stockQnty += count;
                }
            }
            return true;
        }

        public void displayItems()
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

        public Product findByID(string id)
        {
            //Searches for an item by its unique id
            Product result = null;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].prodID == id)
                {
                    result = items[i];
                }
            }
            return result;
        }

        public Product findByGenre(string Genre)
        {
            //Searches for an item by its title
            Product result = null;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].genre == Genre)
                {
                    result = items[i];
                }
            }
            return result;
        }

        public Product findByPrice(double Price)
        {
            //Searches for item by its price
            Product result = null;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].price == Price)
                {
                    result = items[i];
                }
            }
            return result;
        }

        public int getLength()
        {
            return items.Count();
        }
    }
}
