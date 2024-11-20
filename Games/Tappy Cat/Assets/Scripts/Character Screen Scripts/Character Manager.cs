using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//Purpose: Control Characer Management for next and back buttons. Runs code for Play button to switch to game scene and saves and loads previous game character selection

public class CharacterManager : MonoBehaviour
{
    //declare variables
    public CharacterDatabase characterDB;
    public SpriteRenderer artworkSprite;
    private int selectedOption = 0;

    /// <summary>
    /// Checks if selected character exists otherwise shows default or the previous selected character
    /// </summary>
    void Start()
    {
        if (!PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = 0;
        }
        else
        {
            Load();
        }
        UpdateCharacter(selectedOption);
    }

    /// <summary>
    /// Moves to next option of character database
    /// </summary>
    public void NextOption()
    {
        selectedOption++;

        if (selectedOption >= characterDB.CharacterCount)
        {
            selectedOption = 0;
        }
        UpdateCharacter(selectedOption);
        Save();
    }
    /// <summary>
    /// Moves to previous option of character database
    /// </summary>
    public void BackOption()
    {
        selectedOption--;
        if (selectedOption < 0)
        {
            selectedOption = characterDB.CharacterCount - 1;
        }
        UpdateCharacter(selectedOption);
        Save();
    }
    /// <summary>
    /// Updates ball object's sprite to whatever selectedOption is of the character database
    /// </summary>
    /// <param name="selectedOption">the index that the character is in the database</param>
    private void UpdateCharacter(int selectedOption)
    {
        Character character = characterDB.GetCharacter(selectedOption);
        artworkSprite.sprite = character.characterSprite;
    }

    /// <summary>
    /// Loads previous saved data on character choice
    /// </summary>
    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }

    /// <summary>
    /// Saves current game data on character choice
    /// </summary>
    private void Save()
    {
        PlayerPrefs.SetInt("selectedOption", selectedOption);
    }

    /// <summary>
    /// Changes scene from title scene to game scene
    /// </summary>
    /// <param name="sceneID">the ID in which the scene is changed to</param>
    public void ChangeScene()
    {

        SceneManager.LoadScene("Game Scene");

    }

}
