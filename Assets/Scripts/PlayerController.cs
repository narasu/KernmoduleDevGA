using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController
{
    private GameObject playerInstance;
    private Movement movement;

    public PlayerController(GameObject _playerInstance)
    {
        playerInstance = _playerInstance;
        movement = new Movement(playerInstance);
    }
}
