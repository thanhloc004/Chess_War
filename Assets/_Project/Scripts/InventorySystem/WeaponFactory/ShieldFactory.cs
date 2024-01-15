using UnityEngine;


public abstract class ShieldFactory : ScriptableObject
{
    public abstract IShield ProvideShield(Transform hand);
}
