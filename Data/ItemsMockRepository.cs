using System.Collections.Generic;

namespace Freshprints.Data
{
    public static class ItemsMockRepository
    {
        private static readonly List<Item> Items = new List<Item>
        {
            new Item("pencil", "it is used for drawing"),
            new Item("pen", "it is used for writing")
        };
        public static IEnumerable<Item> GetAllItems()
        {
            return Items;
        }

        public static Item GetItemById(int id)
        {
            if (id <= 0)
            {
                return null;
            }
            return id > 2 ? null : Items[id - 1];
        }
        
    }
}