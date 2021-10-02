using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class has the responsibilty of managing all the NPC's, it just spawns them in and then makes them flee as soon as the player starts shooting

public class NPCManager
{
    private List<GameObject> NPCList = new List<GameObject>();
    private int NPCCount = 10;
    private float runAwayTimer;
    private float baseTime = 2;
    private float speed = 1;
    private bool scared = false;
    private float minSpawn = -50;
    private float maxSpawn = 50;

    //When the Manager is created it spawns the NPC's and subscribes them to the shoot event
    public NPCManager(GameObject _NPCInstance)
    {
        for (int i = 0; i < NPCCount; i++)
        {
            Vector3 randomPos = new Vector3(Random.Range(minSpawn, maxSpawn), 0, Random.Range(minSpawn, maxSpawn));
            GameObject tempNPC = GameObject.Instantiate(_NPCInstance, randomPos, new Quaternion()) as GameObject;
            NPCList.Add(tempNPC);
        }
        EventManager.Subscribe(EventType.SHOOT, GetScared);
    }

    //The update loop checks if the NPC's should be scared
    public void UpdateNPC(Vector3 _playerPos)
    {
        if (scared)
        {
            runAwayTimer -= Time.deltaTime;
            RunAway(_playerPos);
        }
        if(runAwayTimer <= 0)
        {
            scared = false;
            runAwayTimer = baseTime;
        }
    }

    //Makes the NPC's scared
    private void GetScared()
    {
        scared = true;
    }

    //Makes the NPC's run away from player, runs when NPC's are scared
    private void RunAway(Vector3 _playerPos)
    {
        foreach(GameObject NPC in NPCList)
        {
            Vector3 playerDir = NPC.transform.position - _playerPos;
            Vector3 runDir = new Vector3(playerDir.x, 0, playerDir.z) * Time.deltaTime * speed;
            NPC.transform.Translate(runDir, Space.World);
        }
    }
}
