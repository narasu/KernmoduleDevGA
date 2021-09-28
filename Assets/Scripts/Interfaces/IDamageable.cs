using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    HealthComponent pHealthComponent 
    { 
        get; 
    }

    void TakeDamage(int _damage);
    void OnHealthZero();
}
