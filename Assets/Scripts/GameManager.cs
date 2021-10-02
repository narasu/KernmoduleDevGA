using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private InputHandler inputHandler;
    private InputSettings inputSettings;
    private PlayerController player;
    private CameraController camera;
    private NPCManager NPCs;
    private EnemyManager enemyManager;
    [SerializeField] private GameObject playerInstance;
    [SerializeField] private GameObject cameraInstance;
    [SerializeField] private GameObject NPCPrefab;

    // Start is called before the first frame update
    void Start()
    {
        inputHandler = new InputHandler();
        inputSettings = new InputSettings(inputHandler);
        player = new PlayerController(playerInstance);
        camera = new CameraController(cameraInstance, playerInstance);
        NPCs = new NPCManager(NPCPrefab);
        enemyManager = new EnemyManager();
    }

    // Update is called once per frame
    void Update()
    {
        inputHandler.HandleInput();
        camera.FollowPlayer();
        NPCs.UpdateNPC(playerInstance.transform.position);
        enemyManager.UpdateEnemies();
    }

}
