using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : IProjectile
{
    private Dictionary<DamageType, int> damage = new Dictionary<DamageType, int>();

    public Bullet(int _damage)
    {
        damage.Add(DamageType.BASE, _damage);
        Decorate(new BulletDecorator(DamageType.FIRE, 10));
        Decorate(new BulletDecorator(DamageType.FIRE, 4));
        Decorate(new BulletDecorator(DamageType.SASS, 10));
    }

    public void Decorate(BulletDecorator _decorator)
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
        foreach (KeyValuePair<DamageType, int> kvp in damage)
        {
            Debug.Log("Did " + kvp.Value + " damage of type " + kvp.Key);
        }
    }
}
