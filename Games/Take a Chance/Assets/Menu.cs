using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
  
    //establish default gamemode and player Count
    public static string selectedGamemode;
    public static int selectedPlayerCount = 1;

    public Game gameManager;

    public Button Addition;
    public Button Subtraction;
    public Button Multiplication;
    public Button Division;


    /// <summary>
    /// Makes the Menu have 1 instance and to be able to go through scene changes
    /// </summary>
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

        //Create Listener for Main Menu Gamemodes
        Addition.onClick.AddListener(() => SelectGamemode("Addition"));
        Subtraction.onClick.AddListener(() => SelectGamemode("Subtraction"));
        Multiplication.onClick.AddListener(() => SelectGamemode("Multiplication"));
        Division.onClick.AddListener(() => SelectGamemode("Division"));

    }

    /// <summary>
    /// sets playercount for the game off of the button associated with it, then reports to debug what the player count is
    /// </summary>
    /// <param name="playerCount">the num of players</param>
    public void SelectPlayerCount(int playerCount)
    {
        selectedPlayerCount = playerCount;
        Debug.Log($"Player Count is set to {selectedPlayerCount}");
        //StartGame(selectedGamemode, selectedPlayerCount);
    }

    /// <summary>
    /// Sets the gamemode being played, then reports to debug what it set
    /// </summary>
    /// <param name="mode">the gamemode being played</param>
    void SelectGamemode(string mode)
    {
        gameManager.Instance.SelectGameMode(mode);
        Debug.Log($"GameMode is set to {mode}");
    }
}
