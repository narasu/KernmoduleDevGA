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
        
    }

    public override void OnExit()
    {

    }

    public override void OnUpdate()
    {
        //IDEA: Transition class for the transitions -> abstract 
        owner.pOwner.WalkToRandomPosition();
        //if (owner.pOwner.distanceToTarget >=  /*must be Vector3*/)
        //{
        //    owner.pOwner.hasHitPlayer = true;
        //    owner.SwitchState(typeof(IdleState));
        //}
    }

}