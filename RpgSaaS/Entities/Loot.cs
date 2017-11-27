namespace Entities
{
    public class Loot : EntityBase
    {
        public int Amount { get; set; }
        public ItemBase Item { get; set; }
        public double Rate { get; set; }

    }
}