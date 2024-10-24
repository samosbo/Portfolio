using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Purpose: Controls what ball sprite is from saved data and controls how ball moves upwards

public class BallScript : MonoBehaviour
{
    //declare variables
    public Rigidbody2D myRigidBody;
    public float bounceStrength;
    public LogicScript logic;
    public bool ballIsAlive = true;
    public CharacterDatabase characterDB;
    public SpriteRenderer artworkSprite;
    private int selectedOption = 0;

    /// <summary>
    /// Finds the logic script and creates base selected Option as first element in character database
    /// if a previous run has a saved character it will load that
    /// </summary>
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
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
    /// Permits character to be able to go upwards via the space key
    /// </summary>
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && ballIsAlive)
        {
            myRigidBody.velocity = Vector2.up * bounceStrength;
        }

        // End game if ball falls too far below game area
        if (transform.position.y < -6 || transform.position.y > 4)
        {
            logic.GameOver();
        }
        
    }

    /// <summary>
    /// Ends game with Game over if collision is made
    /// </summary>
    /// <param name="collision">detects collision with middle trigger of paws</param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        ballIsAlive = false;
    }
    /// <summary>
    /// Update the character sprite on screen to user to the selected option (or whichever index it is on)
    /// </summary>
    /// <param name="selectedOption">the index of character element in the database the user is viewing</param>
    private void UpdateCharacter(int selectedOption)
    {
        Character character = characterDB.GetCharacter(selectedOption);
        artworkSprite.sprite = character.characterSprite;
    }

    /// <summary>
    /// Loads what the user choose thier character as in previous games so reselection is not necessary
    /// </summary>
    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }
}
