using UnityEngine;


[CreateAssetMenu(fileName = "Rocket Shooting Ability", menuName = "Abilities/Rocket Shooting Strategy")]
public class RocketShootingStrategy : AbilityStrategy
{
    public GameObject prefab;
    public override void Execute(Transform origin)
    {
        new ProjectileBuilder()
            .WithPrefab(prefab)
            .Build(origin);
    }
}
