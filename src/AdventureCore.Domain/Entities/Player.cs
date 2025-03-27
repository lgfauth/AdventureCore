namespace AdventureCore.Domain.Entities
{
    public class Player
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Gold { get; set; }
        public Stats Stats { get; set; } = new();
        public List<Item> Inventory { get; set; } = new();
    }
}
