using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : IDamageable
{
    private FSM<Enemy> enemyFSM;

    public HealthComponent pHealthComponent
    {
        get;
        set;
    }

    //spawner gives health
    public Enemy(float _health)
    {
        enemyFSM = new FSM<Enemy>(this);
        pHealthComponent = new HealthComponent(_health);

        ////voorbeeld Transitions class implementatie
        //var state = new IdleState(enemyFSM);
        //state.AddTransition(transition);
        //enemyFSM.AddState(state);

        enemyFSM.AddState(new IdleState(enemyFSM));
        enemyFSM.AddState(new AttackState(enemyFSM));

        //Transition<Enemy> transition = new Transition<Enemy>()
        //{//lambda function
        //    Condition = (x) =>
        //    {
        //        return (x.health <= 0);
        //    },
        //    toState = typeof(IdleState)
        //};

        enemyFSM.SwitchState(typeof(IdleState));

    }


    public void TakeDamage(float _damage)
    {
        pHealthComponent.health -= _damage;

        if (pHealthComponent.health <= 0)
        {
            OnHealthZero();
        }
    }
    public void OnHealthZero()
    {
        //die
        //TODO: shout I died
    }


    // TODO: call enemy update in monobehaviour
    public void Update()
    {
        enemyFSM.Update();
    }

  

}

//public class Transition<T>
//{
//  //predicate is een functie die altijd een bool returned
//    public Predicate<T> Condition;
//    public System.Type toState;
//}