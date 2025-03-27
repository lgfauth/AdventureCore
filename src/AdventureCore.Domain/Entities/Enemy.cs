namespace AdventureCore.Domain.Entities
{
    public class Enemy
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Level { get; set; }
        public Stats Stats { get; set; } = new();
        public List<Item> LootTable { get; set; } = new();
    }
}
