using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Creates all the components for the player
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
