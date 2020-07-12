using System.ComponentModel.DataAnnotations;

namespace dnd.inventory.api.Model
{
    public class Item : IEntity
    {
        public Item() => this.Name = string.Empty;

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(2000)]
        public string? Description { get; set; }

        public decimal Weight { get; set; }

        public decimal PriceInGold { get; set; }

        public ItemType ItemType { get; set; }
    }
}
