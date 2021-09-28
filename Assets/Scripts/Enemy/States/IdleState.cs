using UnityEngine;

public class IdleState: AbstractState<Enemy>
{
    private FSM<Enemy> owner;
    public IdleState(FSM<Enemy> _owner)
    {
        owner = _owner;
    }

    public override void OnEnter()
    {
        throw new System.NotImplementedException();
    }

    public override void OnExit()
    {
        throw new System.NotImplementedException();
    }

    public override void OnUpdate()
    {
        if (Input.GetKey(KeyCode.F))
        {
            //Transition class for the transitions -> abstract 
            owner.SwitchState(typeof(AttackState));
            ////Voorbeeld opvragen enemyhealth
            //owner.pOwner.health = 100;
        }
    }

}