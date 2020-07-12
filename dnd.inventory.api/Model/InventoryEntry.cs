using System.ComponentModel.DataAnnotations.Schema;

namespace dnd.inventory.api.Model
{
    public class InventoryEntry : IEntity
    {
        public int Id { get; set; }

        public int ItemId { get; set; }

        public int Count { get; set; }

        [ForeignKey(nameof(ItemId))]
        public Item? Item { get; set; }
    }
}
