using UnityEngine;

public abstract class AbilityStrategy : ScriptableObject
{
    public abstract void Execute(Transform origin);
}
