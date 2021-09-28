using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageInfo
{
    public float damage;
    public DamageType damageType;

    public DamageInfo(float _damage, DamageType _damageType = DamageType.BASE)
    {
        damage = _damage;
        damageType = _damageType;
    }
}
