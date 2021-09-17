using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tokens : MonoBehaviour
{
    public static int TokenVal;
    public GameObject TokenText;
    float timer;
    public static int tokenMultiplier = 1;

    void Update()
    {
       timer += Time.deltaTime;
       if(timer>=10){
           timer = 0;
           TokenVal += (10*tokenMultiplier);
       }
        TokenText.GetComponent<Text>().text = "Tokens: " + TokenVal;
    }
}
