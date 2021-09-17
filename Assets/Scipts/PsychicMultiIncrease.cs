using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PsychicMultiIncrease : MonoBehaviour
{
    public GameObject ButtonText;
    [SerializeField] int price = 100;
public void IncreasePsychicMulti(){
    if (Tokens.TokenVal >= price){
            Tokens.TokenVal -= price;
            price *= 5;
            Abilities.PsychicMultiplier *= 2;
    }
        ButtonText.GetComponent<Text>().text = "Psychic Multiplier: x" + Abilities.PsychicMultiplier + "  $" + price;
    }
}
