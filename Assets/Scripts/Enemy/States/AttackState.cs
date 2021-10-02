public class AttackState : AbstractState<Enemy>
{
    private FSM<Enemy> owner;

    public AttackState(FSM<Enemy> _owner)
    {
        owner = _owner;
    }

    public override void OnEnter()
    {
        owner.pOwner.speed += 10;
    }

    public override void OnExit()
    {

        owner.pOwner.speed -= 10;
    }

    public override void OnUpdate()
    {
        owner.pOwner.FollowTarget(owner.pOwner.target);
        //if (owner.pOwner.distanceToTarget <= 0 /*moet vector3 zijn*/)
        //{
        //    owner.pOwner.hasHitPlayer = true;
        //    owner.SwitchState(typeof(IdleState));
        //}
    }
}