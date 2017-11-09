namespace EntityBase
{
    public class Item
    {
        public string name { get; set; }
        public string description { get; set; }
        public ItemType type { get; set; }

    }

    public enum ItemType
    {
        HELMET,
        ARMOR,
        LEGS,
        POTION,
        SCROLL,
        WEAPONS,
        SHIELDS
    }
}