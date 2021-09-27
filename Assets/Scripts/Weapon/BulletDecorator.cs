using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDecorator
{
    public int pDamage { get; private set; }

    public DamageType pDamageType { get; private set; }
    
    public BulletDecorator(DamageType _damageType, int _damage)
    {
        pDamageType = _damageType;
        pDamage = _damage;
    }
}
