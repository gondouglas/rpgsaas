namespace Entities
{
    public class Loot : EntityBase
    {
        public int amount { get; set; }
        public ItemBase item { get; set; }
        public double rate { get; set; }

    }
}