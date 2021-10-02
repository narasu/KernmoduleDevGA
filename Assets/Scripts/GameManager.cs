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
    private ProjectileManager projectileManager;
    [SerializeField] private GameObject playerInstance;
    [SerializeField] private GameObject cameraInstance;
    [SerializeField] private GameObject NPCPrefab;
    private static GameManager instance;

    public static GameManager pInstance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }

    public Vector3 GetPlayerPosition()
    {
        return playerInstance.transform.position;
    }

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        inputHandler = new InputHandler();
        inputSettings = new InputSettings(inputHandler);
        player = new PlayerController(playerInstance);
        camera = new CameraController(cameraInstance, playerInstance);
        NPCs = new NPCManager(NPCPrefab);
        enemyManager = new EnemyManager();
        projectileManager = new ProjectileManager();
        new Weapon(20, projectileManager);
    }

    // Update is called once per frame
    void Update()
    {
        inputHandler.HandleInput();
        camera.FollowPlayer();
        NPCs.UpdateNPC(playerInstance.transform.position);
        enemyManager.UpdateEnemies();
        projectileManager.Update();
    }

    
}
