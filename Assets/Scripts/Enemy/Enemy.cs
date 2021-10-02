using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : IDamageable
{
    
    public int speed;
    public bool hasHitPlayer;
    public Vector3 distanceToTarget;
    public Vector3 target;

    private FSM<Enemy> enemyFSM;
    private EnemyManager enemyManager;

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

        ////example Transitions class implementatie
        //var state = new IdleState(enemyFSM);
        //state.AddTransition(transition);
        //enemyFSM.AddState(state);

        enemyFSM.AddState(new IdleState(enemyFSM));
        enemyFSM.AddState(new AttackState(enemyFSM));
        enemyFSM.AddState(new DyingState(enemyFSM));

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

    public void TakeDamage(float _damage, DamageType _damageType = DamageType.BASE)
    {
        pHealthComponent.health -= _damage;

        if (pHealthComponent.health <= 0)
        {
            OnHealthZero();
        }
    }

    public void OnHealthZero()
    {
        enemyManager.OnDeath(this);
        //die & destroy
        enemyFSM.SwitchState(typeof(DyingState));
    }


    public void Update(Vector3 _playerPosition)
    {
        target = _playerPosition;
        enemyFSM.Update();
        //distanceToTarget = this.transform.position - playerPosition

    }

    public void FollowTarget(Vector3 _target)
    {
        //follow _target

       
    }

    public void WalkToRandomPosition()
    {
        //walk to random position
    }

}

//public class Transition<T>
//{
//  //predicate is een functie die altijd een bool returned
//    public Predicate<T> Condition;
//    public System.Type toState;
//}