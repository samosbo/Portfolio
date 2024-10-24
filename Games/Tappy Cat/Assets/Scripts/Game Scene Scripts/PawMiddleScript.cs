using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Purpose: Controls the logic of the ball colliding with the middle which links to score keeping
public class PawMiddleScript : MonoBehaviour
{
    //declare variables
    public LogicScript logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    //Calls addscore from Logic Script to increase score upon collision
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.AddScore(1);
        }
    }
}
