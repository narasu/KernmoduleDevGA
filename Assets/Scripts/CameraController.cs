using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController
{
    private GameObject cameraInstance;
    private GameObject playerInstance;

    private float height = 15;
    private float speed = 20;

    public CameraController(GameObject _cameraInstance, GameObject _playerInstance)
    {
        cameraInstance = _cameraInstance;
        playerInstance = _playerInstance;
    }

    public void FollowPlayer()
    {
        Vector3 camTargetPos = new Vector3(playerInstance.transform.position.x, height, playerInstance.transform.position.z);
        Vector3 camMoveDir = Vector3.MoveTowards(cameraInstance.transform.position, camTargetPos, speed * Time.deltaTime);
        cameraInstance.transform.position = camMoveDir;
    }
}
