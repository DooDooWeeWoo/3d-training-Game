using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenScript : MonoBehaviour
{
 
[HideInInspector]
public Stats stat;
float timer;
public GameObject StatsObject;

    void Start()
    {
        stat = StatsObject.GetComponent<Stats>();
    }


    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 15){
            timer = 0;
            stat.Tokens += (10*stat.TokenMultiplier);
        }
    }
}
