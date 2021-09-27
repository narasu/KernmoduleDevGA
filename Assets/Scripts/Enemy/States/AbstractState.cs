using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractState<T>
{
    public abstract void OnEnter();
    public abstract void OnExit();
    public abstract void OnUpdate();

}