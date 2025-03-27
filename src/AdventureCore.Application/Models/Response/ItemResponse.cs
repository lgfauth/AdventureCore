namespace AdventureCore.Application.Models.Response
{
    public class ItemResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public Dictionary<string, int>? Bonus { get; set; } = new();
    }
}
