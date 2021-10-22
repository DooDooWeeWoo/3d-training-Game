using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StrengthMultiIncrease : MonoBehaviour
{
    public Abilities Stats;
    public GameObject ButtonText;
    [SerializeField] int price = 100;

    void Start() 
    {
        Stats = GetComponent<Abilities>();        
    }
    public void IncreaseStrengthMulti(){
        if (Tokens.TokenVal >= price){
            Tokens.TokenVal -= price;
            price *= 5;
        Stats.StrengthMultiplier *= 2;
        }
        ButtonText.GetComponent<Text>().text = "Strength Multiplier: x" + Stats.StrengthMultiplier + "  $" + price;
    }
}
