using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler
{
    private Dictionary<KeyCode, EventType> keyCommands = new Dictionary<KeyCode, EventType>();

    //Add commands with keys
    public void AddCommand(KeyCode _key, EventType _command)
    {
        keyCommands.Add(_key, _command);
    }

    //Remove command by key
    public void RemoveCommand(KeyCode _key)
    {
        if (keyCommands.ContainsKey(_key))
        {
            keyCommands.Remove(_key);
        }
    }
    
    //remove command by command
    public void RemoveCommand(EventType _command)
    {
        foreach (KeyValuePair<KeyCode, EventType> entry in keyCommands)
        {
            if (entry.Value == _command)
            {
                keyCommands.Remove(entry.Key);
            }
        }
    }

    //Execute the commands
    public void HandleInput()
    {
        foreach (KeyValuePair<KeyCode, EventType> entry in keyCommands)
        {
            if (Input.GetKey(entry.Key))
            {
                EventManager.Invoke(entry.Value);
            }
        }
    }
}
