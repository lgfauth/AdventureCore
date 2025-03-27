namespace AdventureCore.Application.Models.Request
{
    public class ResolveCombatRequest
    {
        public string EnemyId { get; set; } = string.Empty;
        public string Action { get; set; } = "Attack"; // Could be Attack, Defend, Spell, etc.
    }
}
