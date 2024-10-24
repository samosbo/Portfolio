using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Purpose: Controls the score management for high score and current score, also controls game over, restarting game and switching to title screen

public class LogicScript : MonoBehaviour
{
    //declare variables
    public int playerScore = 0;
    public int highscore = 0;
    public Text scoreText;
    public Text highscoreText;
    public GameObject gameOverScreen;

    private void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore",0);
        Application.targetFrameRate = 60;
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
    }

    /// <summary>
    /// Adds an additional point to score controlled by scoreToAdd
    /// </summary>
    /// <param name="scoreToAdd">the value in which the score is increased</param>
    public void AddScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();

        if (highscore < playerScore)
        {
            PlayerPrefs.SetInt("highscore", playerScore);
        }
        
    }

    /// <summary>
    /// Restarts game so it is replayable
    /// </summary>
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    /// <summary>
    /// Ends the game and brings up game over sceen
    /// </summary>
    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }

    /// <summary>
    /// Changes Scene back to title scene
    /// </summary>
    public void ChangeScene()
    {
        SceneManager.LoadScene("Title Scene");
    }
}
