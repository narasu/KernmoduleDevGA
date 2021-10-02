using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class makes sure that the camera follows the player
public class CameraController
{
    private GameObject cameraInstance;
    private GameObject playerInstance;

    private float height = 15;
    private float speed = 20;

    //When created it get the instances from Unity
    public CameraController(GameObject _cameraInstance, GameObject _playerInstance)
    {
        cameraInstance = _cameraInstance;
        playerInstance = _playerInstance;
    }

    //Gets player position and moves towards it
    public void FollowPlayer()
    {
        Vector3 camTargetPos = new Vector3(playerInstance.transform.position.x, height, playerInstance.transform.position.z);
        Vector3 camMoveDir = Vector3.MoveTowards(cameraInstance.transform.position, camTargetPos, speed * Time.deltaTime);
        cameraInstance.transform.position = camMoveDir;
    }
}
