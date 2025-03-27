namespace AdventureCore.Application.Models.Response
{
    public class ExploreResponse
    {
        public string Type { get; set; } = string.Empty; // combat, event, loot
        public string Description { get; set; } = string.Empty;
        public object? Payload { get; set; }
    }
}
