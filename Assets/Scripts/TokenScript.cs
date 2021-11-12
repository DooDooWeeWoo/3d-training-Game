using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenScript : MonoBehaviour
{
 
[HideInInspector] //hide the referenceable script in the unity inspector
public Stats stat;
float timer; //create a float for the timer
public GameObject StatsObject; //create a gameobject which the Stats script is connected to

    void Start() //upon starting
    {
        stat = StatsObject.GetComponent<Stats>(); //get the referenceable script
    }


    void Update()
    {
        timer += Time.deltaTime; //Time.deltaTime is the time difference between two frames. Increment the timer by Time.deltaTime
        if (timer >= 15){ //Once the timer is over or equal to 15 seconds
            timer = 0; //set the timer to zero
            stat.Tokens += (10*stat.TokenMultiplier); //increase the players tokens by 10 * the token multiplier
        }
    }
}
