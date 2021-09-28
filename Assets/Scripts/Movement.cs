using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement
{
    private GameObject playerInstance;
    private Vector3 movement;
    private float speed = 0.01f;

    public Movement(GameObject _playerInstance)
    {
        playerInstance = _playerInstance;
        EventManager.Subscribe(EventType.MOVE_FORWARDS, Forward);
        EventManager.Subscribe(EventType.MOVE_BACKWARDS, Backward);
        EventManager.Subscribe(EventType.MOVE_LEFT, Left);
        EventManager.Subscribe(EventType.MOVE_RIGHT, Right);
    }

    private void Forward()
    {
        movement.z += 1 * Time.deltaTime * speed;
        Move();
    }

    private void Backward()
    {
        movement.z -= 1 * Time.deltaTime * speed;
        Move();
    }

    private void Left()
    {
        movement.x -= 1 * Time.deltaTime * speed;
        Move();
    }

    private void Right()
    {
        movement.x += 1 * Time.deltaTime * speed;
        Move();
    }

    private void Move()
    {
        playerInstance.transform.Translate(movement.normalized, Space.World);
        Rotate();
        movement = new Vector3();
    }

    private void Rotate()
    {
        Vector3 walkToo = new Vector3(0, 0, 0) + movement;
        Quaternion walkDir = Quaternion.LookRotation(walkToo);
        playerInstance.transform.rotation = Quaternion.Slerp(playerInstance.transform.rotation, walkDir, 1);
    }

    ~Movement()
    {
        EventManager.Unsubscribe(EventType.MOVE_FORWARDS, Forward);
        EventManager.Unsubscribe(EventType.MOVE_BACKWARDS, Backward);
        EventManager.Unsubscribe(EventType.MOVE_LEFT, Left);
        EventManager.Unsubscribe(EventType.MOVE_RIGHT, Right);
    }
}
