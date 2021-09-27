using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : IDamageable
{
    public int pHealth { get; private set; }

    public HealthComponent(int _health)
    {
        pHealth = _health;
    }

    public void TakeDamage(int _damage)
    {
        pHealth -= _damage;

        if (pHealth <= 0)
        {
            OnHealthZero();
        }    
    }

    public void OnHealthZero()
    {
        // die
    }
}
