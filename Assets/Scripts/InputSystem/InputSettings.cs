using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSettings
{

    public KeyCode forward = KeyCode.W;
    public KeyCode backward = KeyCode.S;
    public KeyCode left = KeyCode.A;
    public KeyCode right = KeyCode.D;
    public KeyCode reload = KeyCode.R;
    public KeyCode menu = KeyCode.Escape;
    public KeyCode shoot = KeyCode.Mouse1;

    private InputHandler inputHandler;

    public InputSettings(InputHandler _inputHandler)
    {
        inputHandler = _inputHandler;
        inputHandler.AddCommand(forward, EventType.MOVE_FORWARDS);
        inputHandler.AddCommand(backward, EventType.MOVE_BACKWARDS);
        inputHandler.AddCommand(left, EventType.MOVE_LEFT);
        inputHandler.AddCommand(right, EventType.MOVE_RIGHT);
        inputHandler.AddCommand(reload, EventType.RELOAD);
        inputHandler.AddCommand(shoot, EventType.SHOOT);
    }
}
