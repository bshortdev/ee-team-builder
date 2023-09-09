namespace ExceededTeamBuilder.Domain.Entities;

public class Species
{
    public decimal Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int BaseHitPoints { get; set; }
    public int BaseAttack { get; set; }
    public int BaseDefense { get; set; }
    public int BaseSpecialAttack { get; set; }
    public int BaseSpecialDefense { get; set; }
    public int BaseSpeed { get; set; }
    public Type FirstType { get; set; } = new();
    public Type? SecondType { get; set; }
    public Ability FirstAbility { get; set; } = new();
    public Ability? SecondAbility { get; set; }
    public Ability? HiddenAbility { get; set; }
    public Ability FirstInnate { get; set; } = new();
    public Ability? SecondInnate { get; set; }
    public Ability? ThirdInnate { get; set; }

}
