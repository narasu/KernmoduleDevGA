using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        damage.Add(pDamageInfo.damageType, pDamageInfo.damage);
        Decorate(new DamageDecorator(new DamageInfo(10.0f, DamageType.FIRE)));
        Decorate(new DamageDecorator(new DamageInfo(4.0f, DamageType.FIRE)));
        Decorate(new DamageDecorator(new DamageInfo(10.0f, DamageType.SASS)));
    }

    public void Update()
    {

    }

    public void Decorate(DamageDecorator _decorator)
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
        }
    }
}
