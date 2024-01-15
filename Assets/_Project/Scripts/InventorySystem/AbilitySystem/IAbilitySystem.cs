using System.Collections.Generic;

public interface IAbilitySystem
{
    List<ICommand> Commands { get; }

    void Add(ICommand command);
    void Remove(ICommand command);
    void ExecuteCommandAt(int index);
    void Debug();
}
