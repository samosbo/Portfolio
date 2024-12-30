using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCountManager : MonoBehaviour
{
    public Game gameManager;
    public Button onePlayerButton;
    public Button twoPlayerButton;
    public Button threePlayerButton;
    public Button fourPlayerButton;

    void Start()
    {
        
        onePlayerButton.onClick.AddListener(() => SetPlayerCount(1));
        twoPlayerButton.onClick.AddListener(() => SetPlayerCount(2));
        threePlayerButton.onClick.AddListener(() => SetPlayerCount(3));
        fourPlayerButton.onClick.AddListener(() => SetPlayerCount(4));

        Debug.Log("Game Mode in Player Scene: " + gameManager.Instance.selectedGameMode);
    }

    public void SetPlayerCount(int count)
    {
        gameManager.Instance.SetPlayerCount(count);
        Debug.Log("Player count set to: " + count);
    }
}
