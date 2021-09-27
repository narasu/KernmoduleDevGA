using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet
{
    private Dictionary<DamageType, int> damage;
    private List<DamageDecorator> decorators;

    public Bullet(int _damage)
    {
        damage.Add(DamageType.BASE, _damage);

        Decorate(new DamageDecorator(DamageType.FIRE, 10));
        Decorate(new DamageDecorator(DamageType.FIRE, 4));
        Decorate(new DamageDecorator(DamageType.SASS, 10));
    }

    public void Decorate(DamageDecorator _decorator)
    {
        decorators.Add(_decorator);

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
