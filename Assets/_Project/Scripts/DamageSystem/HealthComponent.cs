using Sirenix.OdinInspector;
using UnityEngine;

public class HealthComponent : MonoBehaviour, IDamageable
{
    [Title("Info")]
    [SerializeField] private float health;
    [SerializeField] private float maxHealth;


    public float Health
    {
        get { return health; }
        set { health = value; }
    }
    public float MaxHealth
    {
        get { return maxHealth; }
        set { maxHealth = value; }
    }

    public event IDamageable.TakeDamageEvent OnTakingDamage;
    public event IDamageable.DeathEvent OnDeath;

    public void TakeDamage(DamageInfo damageInfo)
    {
        throw new System.NotImplementedException();
    }
}
