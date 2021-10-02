/// <summary>
/// HealthComponent contains the health value of an entity and is required by the IDamageable interface.
/// </summary>
public class HealthComponent
{
    public float health;

    public HealthComponent(float _health)
    {
        health = _health;
    }
}
