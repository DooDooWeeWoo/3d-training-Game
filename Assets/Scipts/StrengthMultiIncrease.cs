using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StrengthMultiIncrease : MonoBehaviour
{
    public GameObject ButtonText;
    [SerializeField] int price = 100;
    public void IncreaseStrengthMulti(){
        if (Tokens.TokenVal >= price){
            Tokens.TokenVal -= price;
            price *= 5;
        Abilities.StrengthMultiplier *= 2;
        }
        ButtonText.GetComponent<Text>().text = "Strength Multiplier: x" + Abilities.StrengthMultiplier + "  $" + price;
    }
}
