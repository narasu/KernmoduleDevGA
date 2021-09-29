using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ProjectileManager maintains a list of all instances of IProjectile and updates them.
/// </summary>
public class ProjectileManager
{
    private List<IProjectile> projectiles = new List<IProjectile>();

    public void Add(IProjectile _projectile)
    {
        projectiles.Add(_projectile);
    }

    public void Update()
    {
        for(int i = 0; i < projectiles.Count; i++)
        {
            projectiles[i].Update();
        }
    }

    
}
