using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TokenMultiIncrease : MonoBehaviour
{

    public GameObject ButtonText;
    [SerializeField] int price = 1000;

    public void IncreaseTokenMulti(){
        if (Tokens.TokenVal >= price){
            Tokens.TokenVal -= price;
            price *= 10;
            Tokens.tokenMultiplier *= 2;
        }
        ButtonText.GetComponent<Text>().text = "Token Multiplier: x" + Tokens.tokenMultiplier + "  $" + price;
    }
}
