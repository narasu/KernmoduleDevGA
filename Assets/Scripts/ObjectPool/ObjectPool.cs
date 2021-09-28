using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The more I thought about implementing this, the more I felt it unnecessarily complicates things
public class ObjectPool<T> where T : IPoolable
{
    private List<T> activePool = new List<T>();
    private List<T> inactivePool = new List<T>();

    private T AddObjectToPool()
    {
        T instance = (T)Activator.CreateInstance(typeof(T));
        inactivePool.Add(instance);
        return instance;
    }

    public T RequestObject()
    {
        if (inactivePool.Count>0)
        {
            return EnableItem(inactivePool[0]);
        }
        return EnableItem(AddObjectToPool());
    }

    public T EnableItem(T _item)
    {
        _item.OnEnableObject();
        _item.pActive = true;
        if (inactivePool.Contains(_item))
        {
            inactivePool.Remove(_item);
        }
        activePool.Add(_item);
        return _item;
    }

    public void DisableItem(T _item)
    {
        if (activePool.Contains(_item))
        {
            activePool.Remove(_item);
        }
        _item.OnDisableObject();
        _item.pActive = false;
        inactivePool.Add(_item);
    }
}
