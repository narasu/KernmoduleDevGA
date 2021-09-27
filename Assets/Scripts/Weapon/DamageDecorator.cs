using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDecorator
{
    public int pDamage { get; private set; }
    public DamageType pDamageType { get; private set; } = DamageType.BASE;
    
    public DamageDecorator(DamageType _damageType, int _damage)
    {
        pDamageType = _damageType;
        pDamage = _damage;
    }
}
