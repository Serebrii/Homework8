using System.Collections.Generic;
using System.Linq;

namespace Solid1
{
    class Item
    {
        public int Price { get; set; }
    }

    class Order
    {
        private List<Item> itemList = new List<Item>();

        public List<Item> ItemList => itemList;

        public void AddItem(Item item)
        {
            itemList.Add(item);
        }

        public void DeleteItem(Item item)
        {
            itemList.Remove(item);
        }

        public int GetItemCount()
        {
            return itemList.Count;
        }

        public decimal CalculateTotalSum()
        {
            return itemList.Sum(item => item.Price);
        }
    }

    class OrderDisplay
    {
        public void PrintOrder(Order order)
        {
        
        }

        public void ShowOrder(Order order)
        {
        
        }
    }

    class OrderPersistence
    {
        public void Save(Order order)
        {
        
        }

        public void Load(int orderId)
        {
        
        }

        public void Update(Order order)
        {
        
        }

        public void Delete(int orderId)
        {
        
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
