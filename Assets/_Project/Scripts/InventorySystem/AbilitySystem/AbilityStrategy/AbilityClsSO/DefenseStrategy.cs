using UnityEngine;


[CreateAssetMenu(fileName = "Defense Ability", menuName = "Abilities/Defense Strategy")]
public class DefenseStrategy : AbilityStrategy
{
    public GameObject prefab;
    public override void Execute(Transform origin)
    {
        throw new System.NotImplementedException();
    }
}
