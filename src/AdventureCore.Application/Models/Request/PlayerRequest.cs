namespace AdventureCore.Application.Models.Request
{
    public class PlayerRequest
    {
        /// <summary>
        /// The name of player
        /// </summary>
        /// <example>Jhon Cena</example>
        public string Name { get; set; }

        /// <summary>
        /// A class of player
        /// </summary>
        /// <example>Barbarian</example>
        public string Class { get; set; }
    }
}
