using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon
{
    private int ammo;
    private int maxAmmo;

    public Weapon(int _maxAmmo)
    {
        maxAmmo = _maxAmmo;
    }

    public void Shoot(int _damage)
    {
        Bullet bullet = new Bullet(_damage);
    }
}
