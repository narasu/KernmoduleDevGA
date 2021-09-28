using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDecorator
{
    public float pDamage { get; private set; }
    public DamageType pDamageType { get; private set; } = DamageType.BASE;
    
    public DamageDecorator(DamageInfo _damageInfo)
    {
        pDamageType = _damageInfo.damageType;
        pDamage = _damageInfo.damage;
    }
}
