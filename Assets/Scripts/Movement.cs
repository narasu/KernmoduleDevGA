using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement
{
    private GameObject playerInstance;
    private Vector3 movement;
    private float speed = 5;

    public Movement(GameObject _playetInstance)
    {
        playerInstance = _playetInstance;
        EventManager.Subscribe(EventType.MOVE_FORWARDS, Forward);
        EventManager.Subscribe(EventType.MOVE_BACKWARDS, Backward);
        EventManager.Subscribe(EventType.MOVE_LEFT, Left);
        EventManager.Subscribe(EventType.MOVE_RIGHT, Right);
    }

    private void Forward()
    {
        movement.x += 1;
        Move();
    }

    private void Backward()
    {
        movement.x -= 1;
        Move();
    }

    private void Left()
    {
        movement.z += 1;
        Move();
    }

    private void Right()
    {
        movement.z -= 1;
        Move();
    }

    private void Move()
    {
        movement = movement * Time.deltaTime * speed;
        playerInstance.transform.Translate(movement.normalized);
        movement = new Vector3();
    }

}
