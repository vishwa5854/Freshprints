using System.ComponentModel.DataAnnotations;

namespace Freshprints.Data
{
    public class Item
    {
        [Key]
        public string ItemName { get; set; }

        [Required]
        public string ItemDescription { get; set; }

        public Item(string itemName, string itemDescription)
        {
            ItemName = itemName;
            ItemDescription = itemDescription;
        }
        
    }
}