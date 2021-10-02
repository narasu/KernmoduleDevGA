public class DyingState : AbstractState<Enemy>
{

    private FSM<Enemy> owner;
    public DyingState(FSM<Enemy> _owner)
    {
        owner = _owner;
    }

    public override void OnEnter()
    {
        //start animation
    }

    public override void OnExit()
    {
        //destoy this object
    }

    public override void OnUpdate()
    {
        //update animation?
    }
}