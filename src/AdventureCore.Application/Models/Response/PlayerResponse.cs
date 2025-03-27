namespace AdventureCore.Application.Models.Response
{
    public class PlayerResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Gold { get; set; }
        public StatsResponse Stats { get; set; } = new();
    }
}
