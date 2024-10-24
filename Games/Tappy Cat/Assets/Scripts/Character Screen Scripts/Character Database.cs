using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Controls the Character Database for Character Selection

[CreateAssetMenu]
public class CharacterDatabase : ScriptableObject
{
    //declare variables
    public Character[] character;

    //Gets value for character list for character selection
    public int CharacterCount
    {
        get
        {
            return character.Length;
        }
    }

    //finds character index for storing purposes in the database
    public Character GetCharacter(int index)
    {
        return character[index];
    }
}
