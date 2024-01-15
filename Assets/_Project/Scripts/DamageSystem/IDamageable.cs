public interface IDamageable
{
    public float Health { get; }
    public float MaxHealth { get; }

    public delegate void TakeDamageEvent(float damage);
    public delegate void DeathEvent();

    public event TakeDamageEvent OnTakingDamage;
    public event DeathEvent OnDeath;
    public void TakeDamage(DamageInfo damageInfo);
}
