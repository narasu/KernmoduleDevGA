using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon
{
    private int ammo;
    private int maxAmmo;
    private ProjectileManager projectileManager;

    public Weapon(int _maxAmmo, ProjectileManager _projectileManager)
    {
        maxAmmo = _maxAmmo;
        ammo = maxAmmo;
        projectileManager = _projectileManager;
        EventManager.Subscribe(EventType.RELOAD, Reload);
    }

    //TODO: subscribe to Shoot Input event
    public void Shoot() 
    {
        if (ammo <= 0)
        {
            Debug.Log("Out of ammo!");
            Reload();
            return;
        }
        Debug.Log("Shooting");
        IProjectile bullet = new Bullet(new DamageInfo(1.0f));
        projectileManager.Add(bullet);
        ammo--;
    }

    public void Reload()
    {
        Debug.Log("Reloading");
        ammo = maxAmmo;
    }

    ~Weapon()
    {
        EventManager.UnSubscribe(EventType.RELOAD, Reload);
    }
}
