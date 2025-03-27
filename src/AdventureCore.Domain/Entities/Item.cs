namespace AdventureCore.Domain.Entities
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty; // Weapon, Armor, Consumable, etc.
        public Dictionary<string, int> Bonus { get; set; } = new();
    }
}
