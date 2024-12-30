using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{

    public static Game Instance;

    public string selectedGameMode;
    public int playerCount;

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

    public void SetGameMode(string mode)
    {
        selectedGameMode = mode;
        Debug.Log("Game mode set to " + selectedGameMode);
    }

    public void SetPlayerCount(int count)
    {
        playerCount = count;
        Debug.Log("PLayer count set to " + playerCount);
    }
}
