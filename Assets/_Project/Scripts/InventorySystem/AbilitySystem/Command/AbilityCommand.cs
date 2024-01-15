using UnityEngine;

public class AbilityCommand : ICommand
{
    public string Name { get; }
    public AbilityStrategy abilityStrategy;

    public AbilityCommand(AbilityStrategy abilityStrategy)
    {
        Name = abilityStrategy.name;
        this.abilityStrategy = abilityStrategy;
    }

    public void Execute()
    {
        
    }
}
