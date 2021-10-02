using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Enums of all eventtypes
public enum EventType
{    
    JUMP             = 0,
    RELOAD           = 1,
    MOVE_FORWARDS    = 2,
    MOVE_BACKWARDS   = 3,
    MOVE_LEFT        = 4,
    MOVE_RIGHT       = 5,
    SHOOT            = 6
}

//Eventmanager takes care of all the events
public static class EventManager
{
    private static Dictionary<EventType, System.Action> eventDictionary = new Dictionary<EventType, System.Action>();

    //Used for subscribing to events
    public static void Subscribe(EventType _type, System.Action _function)
    {
        if (!eventDictionary.ContainsKey(_type))
        {
            eventDictionary.Add(_type, null);
        }
        eventDictionary[_type] += _function;
    }

    //Used for unsubscribing from events
    public static void Unsubscribe(EventType _type, System.Action _function) 
    {
        if (eventDictionary.ContainsKey(_type) && eventDictionary[_type] != null)
        {
            eventDictionary[_type] -= _function;
        }
    }

    //Used for invoking events
    public static void Invoke(EventType _type)
    {
        eventDictionary[_type]?.Invoke();
    }

}
