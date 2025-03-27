namespace AdventureCore.Application.Models.Response
{
    public class CombatResultResponse
    {
        public string Result { get; set; } = "Victory";
        public int XpGained { get; set; }
        public int GoldGained { get; set; }
        public List<ItemResponse> Loot { get; set; } = new();
        public StatsResponse PlayerStatus { get; set; } = new();
    }
}
