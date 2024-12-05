using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Purpose: Controls how fast paws move and when they get deleted and logging it
public class PawMoveScript : MonoBehaviour
{
    //declare variables
    public float moveSpeed = 5;
    public float deadZone = -7;


    /// <summary>
    /// Every frame controls how much the paws move and when it will be destoryed
    /// </summary>
    void Update()
    {
        
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;
        //Gets rid of paws and reports it to log
        if (transform.position.x < deadZone )
        {
            Debug.Log("Paw Deleted.");
            Destroy(gameObject);
        }
    }
}
