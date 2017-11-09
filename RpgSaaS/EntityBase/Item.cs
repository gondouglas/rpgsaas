namespace EntityBase
{
    public abstract class Item
    {
        public string name { get; set; }
        public string description { get; set; }

        public abstract CharacterBase applyEffect(CharacterBase character);
    }
}