using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// IDamager is implemented on any object that can do damage to an IDamageable object.
/// </summary>
public interface IDamager
{
    DamageInfo pDamageInfo 
    { 
        get; 
    }
}
