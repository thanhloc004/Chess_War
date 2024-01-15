using System.Collections.Generic;
using UnityEngine;

public class PlayerEquipment : MonoBehaviour, IEntity
{
    [SerializeField] private List<AbilityStrategy> abilities;
    private IAbilitySystem abilitySystem;


    private void Awake()
    {
        abilitySystem = new AbilitySystem.Builder(this)
            .WithAbilities(abilities)
            .Build();

        abilitySystem.Debug();
    }
}
