namespace ExceededTeamBuilder.Domain.Entities;

public class Type
{
    public decimal Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<Type> TypesWeakAgainst { get; set; } = new();
    public List<Type> TypesResistantAgainst { get; set; } = new();
    public List<Type> TypesImmuneAgainst { get; set; } = new();
    public List<Type> TypesStrongAgainst { get; set; } = new();
    public List<Type> TypesIneffectiveAgainst { get; set; } = new();
    public List<Type> TypesNonEffectiveAgainst { get; set; } = new();
}
