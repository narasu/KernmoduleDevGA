using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    int pHealth { get; set; }

    void TakeDamage(int _damage);
}
