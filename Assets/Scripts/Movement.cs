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
        EventManager<float>.Subscribe(EventType.MOVE_FORWARDS, Forward);
        EventManager<float>.Subscribe(EventType.MOVE_BACKWARDS, Backward);
        EventManager<float>.Subscribe(EventType.MOVE_LEFT, Left);
        EventManager<float>.Subscribe(EventType.MOVE_RIGHT, Right);
    }

    private void Forward(float _float)
    {
        movement.x += 1;
        Move();
    }

    private void Backward(float _float)
    {
        movement.x -= 1;
        Move();
    }

    private void Left(float _float)
    {
        movement.z += 1;
        Move();
    }

    private void Right(float _float)
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
