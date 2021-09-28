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
        EventManager.Subscribe(EventType.RELOAD, Reload);
    }

    public void Shoot() //TODO: subscribe to Shoot Input event
    {
        if (ammo <= 0)
        {
            Debug.Log("Out of ammo!");
            Reload();
            return;
        }
        Debug.Log("Shooting");
        IProjectile bullet = new Bullet(new DamageInfo(1.0f));
        bullet.OnHit();
        ammo--;
    }

    public void Reload() //TODO: subscribe to Reload Input event
    {
        Debug.Log("Reloading");
        ammo = maxAmmo;
    }

    ~Weapon()
    {
        EventManager.UnSubscribe(EventType.RELOAD, Reload);
    }
}
