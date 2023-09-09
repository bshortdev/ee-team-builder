namespace ExceededTeamBuilder.Domain.Entities
{
    public class Move
    {
        public decimal Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public decimal PowerPoints { get; set; }
        public decimal? Power { get; set; }
        public decimal? Accuracy { get; set; }
    }
}
