using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The Bullet class is a projectile fired from a weapon that can damage an IDamageable object.
/// </summary>
public class Bullet : IProjectile, IDamager
{
    private Dictionary<DamageType, float> damage = new Dictionary<DamageType, float>();
    public DamageInfo pDamageInfo
    {
        get; private set;
    }

    public Bullet(DamageInfo _damageInfo)
    {
        pDamageInfo = _damageInfo;
        damage.Add(pDamageInfo.pDamageType, pDamageInfo.pDamage);
        Decorate(new DamageInfo(10.0f, DamageType.FIRE));
        Decorate(new DamageInfo(4.0f, DamageType.FIRE));
        Decorate(new DamageInfo(10.0f, DamageType.SASS));
    }

    public void Update()
    {
        /* TODO:
         * move in direction
         * if (collision with IDamageable)
         * {
         *     OnHit();
         * }
         */
        IDamageable i;
    }

    public void Decorate(DamageInfo _decorator)
    {
        if (!damage.ContainsKey(_decorator.pDamageType))
        {
            damage.Add(_decorator.pDamageType, _decorator.pDamage);
            return;
        }
        damage[_decorator.pDamageType] += _decorator.pDamage;
    }

    public void OnHit()
    {
        foreach (KeyValuePair<DamageType, float> kvp in damage)
        {
            Debug.Log("Did " + kvp.Value + " damage of type " + kvp.Key);
            // IDamageable.TakeDamage(kvp.Value, kvp.Key); 
        }
    }
}
