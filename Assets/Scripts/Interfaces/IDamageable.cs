using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// IDamageable is implemented on any class which can be damaged by an IDamager. 
/// </summary>
public interface IDamageable
{
    HealthComponent pHealthComponent 
    { 
        get; 
    }

    void TakeDamage(float _damage, DamageType _damageType = DamageType.BASE);
    void OnHealthZero();
}
