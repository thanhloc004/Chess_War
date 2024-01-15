using UnityEngine;

[CreateAssetMenu(fileName = "Shield", menuName = "Weapons/Shield")]
public class GenericShieldFactory : ShieldFactory
{
    public override IShield ProvideShield(Transform hand)
    {
        throw new System.NotImplementedException();
    }
}
