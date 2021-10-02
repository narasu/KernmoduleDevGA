/// <summary>
/// IProjectile is implemented on any object which is meant to travel somewhere and hit another object.
/// </summary>
public interface IProjectile
{
    void Update();
    void OnHit(IDamageable _damageable = null);
}