using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The DamageInfo class contains one damage value of a certain type.
/// Used with any class that implements the IDamager interface.
/// </summary>
public class DamageInfo
{
    public float pDamage
    {
        get; private set;
    }
    public DamageType pDamageType
    {
        get;
        private set;
    }

    public DamageInfo(float _damage, DamageType _damageType = DamageType.BASE)
    {
        pDamage = _damage;
        pDamageType = _damageType;
    }
}
