using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    private List<GameObject> NPCList = new List<GameObject>();
    private int NPCCount = 10;
    private float runAwayTimer;
    private float baseTime = 2;
    private float speed = 1;
    private bool scared = false;
    private float minSpawn = -50;
    private float maxSpawn = 50;

    public NPCManager(GameObject _NPCInstance)
    {
        for (int i = 0; i < NPCCount; i++)
        {
            Vector3 randomPos = new Vector3(Random.Range(minSpawn, maxSpawn), 0, Random.Range(minSpawn, maxSpawn));
            GameObject tempNPC = Instantiate(_NPCInstance, randomPos, new Quaternion());
            NPCList.Add(tempNPC);
        }
        EventManager.Subscribe(EventType.SHOOT, GetScared);
    }

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

    private void GetScared()
    {
        scared = true;
    }

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
