using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageableExample : IDamageable
{
    public HealthComponent pHealthComponent { get; set; }

    public DamageableExample(float _health)
    {
        pHealthComponent.health = _health;
    }

    public void TakeDamage(float _damage, DamageType _damageType = DamageType.BASE)
    {
        pHealthComponent.health -= _damage;

        if (pHealthComponent.health <= 0)
        {
            OnHealthZero();
        }
    }

    public void OnHealthZero()
    {
        // die
    }
}
