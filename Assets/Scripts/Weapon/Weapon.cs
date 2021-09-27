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
        ammo = maxAmmo;
    }

    public void Shoot(int _damage)
    {
        if (ammo <= 0)
        {
            Reload();
            return;
        }

        Bullet bullet = new Bullet(_damage);
        ammo--;
    }

    public void Reload()
    {
        ammo = maxAmmo;
    }
}
