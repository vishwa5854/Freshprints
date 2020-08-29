using System.Collections.Generic;

namespace Freshprints.Data
{
    public class ItemsMockRepository
    {

        public static IEnumerable<Item> GetAllItems()
        {
            var items = new List<Item>
            {
                new Item("pencil", "it is used for drawing"),
                new Item("pen", "it is used for writing")
            };
            return items;
        }

        public static Item GetItemById(int id)
        {
            return new Item("pencil", "it is used for drawing");
        }
        
    }
}