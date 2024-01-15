using Sirenix.Utilities;
using System.Collections.Generic;

public class AbilitySystem : IAbilitySystem
{
    public List<ICommand> Commands { get; private set; } = new List<ICommand>();


    private AbilitySystem() { }

    public class Builder
    {
        private IEntity entity;
        private List<AbilityStrategy> abilities;

        public Builder(IEntity entity)
        {
            this.entity = entity;
        }

        public Builder WithAbilities(List<AbilityStrategy> abilities)
        {
            this.abilities = abilities;
            return this;
        }

        public AbilitySystem Build()
        {
            var abilitySystem = new AbilitySystem();
            foreach (var ability in this.abilities)
            {
                abilitySystem.Add(new AbilityCommand(ability));
            }

            return abilitySystem;
        }
    }
    public void Add(ICommand command)
    {
        if(Commands.Contains(command)) return;
        Commands.Add(command);
    }

    public void Remove(ICommand command)
    {
        if(!Commands.Remove(command)) return;
        Commands.Remove(command);
    }

    public void ExecuteCommandAt(int index)
    {
        Commands[index].Execute();
    }
    
    public void Debug()
    {
        if (Commands.IsNullOrEmpty())
        {
            UnityEngine.Debug.Log("Command is null of enpty");
            return;
        }
        foreach (var command in Commands)
        {
            UnityEngine.Debug.Log($"{command}");
        }
    }
}
