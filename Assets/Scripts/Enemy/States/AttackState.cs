internal class AttackState : AbstractState<Enemy>
{
    private FSM<Enemy> enemyFSM;

    public AttackState(FSM<Enemy> enemyFSM)
    {
        this.enemyFSM = enemyFSM;
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
        throw new System.NotImplementedException();
    }
}