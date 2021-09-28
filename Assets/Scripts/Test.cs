using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    Weapon weapon;
    // Start is called before the first frame update
    void Start()
    {
        weapon = new Weapon(12);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            weapon.Shoot(3);
        }
    }
}
