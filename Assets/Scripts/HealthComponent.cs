/// <summary>
/// HealthComponent needs to be used in any class that implements the IDamageable interface
/// </summary>
public class HealthComponent
{
    public float health;

    public HealthComponent(float _health)
    {
        health = _health;
    }
}
