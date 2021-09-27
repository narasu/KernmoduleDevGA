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
            owner.SwitchState(typeof(AttackState));
        }
    }

}