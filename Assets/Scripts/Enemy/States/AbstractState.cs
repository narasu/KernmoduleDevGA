using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractState<T>
{
    public abstract void OnEnter();
    public abstract void OnExit();
    public abstract void OnUpdate();
    ////transitions 
    //public virtual void CheckTransitions()
    //{
    //    foreach(Transition<T> transition in transitions)
    //    {
    //        if (transition.Condition(owner.pOwner))
    //        {
    //            owner.SwitchState(transition.toState);
    //        }
    //    }
    //}

}
