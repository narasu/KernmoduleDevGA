using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private InputHandler inputHandler;
    private InputSettings inputSettings;
    private PlayerController player;
    [SerializeField] private GameObject playerInstance;

    // Start is called before the first frame update
    void Start()
    {
        inputHandler = new InputHandler();
        inputSettings = new InputSettings(inputHandler);
        player = new PlayerController(playerInstance);
    }

    // Update is called once per frame
    void Update()
    {
        inputHandler.HandleInput();
    }

}
