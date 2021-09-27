using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy 
{
    private int health;
    private FSM<Enemy> enemyFSM;

    public Enemy()
    {
        enemyFSM = new FSM<Enemy>(this);
        enemyFSM.AddState(new IdleState(enemyFSM));
        enemyFSM.AddState(new AttackState(enemyFSM));
        enemyFSM.SwitchState(typeof(IdleState));

    }

    // Update is called once per frame
    void Update()
    {
        enemyFSM.Update();
    }
}
