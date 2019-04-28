using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    public class inventory
    {
        public List<product> items;

        public inventory()
        {
            //initializing attributes
            items = new List<product>();
        }

        //Make an array of the items in the manager
        public product[] getItemArray()
        {
            int index = 0;
            product[] itemArr = new product[items.Count];
            foreach (product item in items)
            {
                product i = item;
                itemArr[index++] = i;
            }
            return itemArr;
        }

        public List<product> getItemList()
        {
            List<product> listIM = new List<product>();

            foreach (product i in items)
            {
                product item = i;
                listIM.Add(i);
            }
            return listIM;
        }

        public bool addItem(product item)
        {
            if (items.Contains(item))
                return false;
            items.Add(item);
            return true;
        }

        public bool removeItem(product item)
        {
            //Ability to remove an item from the list
            items.Remove(item);
            return true;
        }

        public bool restockItem(int count, product item)
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

        public product findByID(string id)
        {
            //Searches for an item by its unique id
            product result = null;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].prodID == id)
                {
                    result = items[i];
                }
            }
            return result;
        }

        public product findByGenre(string Genre)
        {
            //Searches for an item by its title
            product result = null;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].genre == Genre)
                {
                    result = items[i];
                }
            }
            return result;
        }

        public product findByPrice(double Price)
        {
            //Searches for item by its price
            product result = null;
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
