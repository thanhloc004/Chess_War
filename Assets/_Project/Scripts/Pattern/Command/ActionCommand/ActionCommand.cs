using System.Threading.Tasks;
using UnityEngine;
using static System.Activator;

public abstract class ActionCommand : ICommandAsync
{
    protected readonly IEntityTurn entityTurn;
    public ActionCommand(IEntityTurn entityTurn)
    {
        this.entityTurn = entityTurn;
    }
    public abstract Task ExeciteAsync();
   
    public static T Create<T>(IEntityTurn entityTurn) where T : ActionCommand
    {
        return (T) CreateInstance(typeof(T), entityTurn);
    }
}
