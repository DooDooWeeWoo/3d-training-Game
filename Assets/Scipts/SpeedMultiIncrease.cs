using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedMultiIncrease : MonoBehaviour
{
    public GameObject ButtonText;
    [SerializeField] int price = 100;
  public void IncreaseAgilityMulti(){
      if (Tokens.TokenVal >= price){
            Tokens.TokenVal -= price;
            price *= 5;
            Abilities.AgilityMultiplier *= 2;
        }
        ButtonText.GetComponent<Text>().text = "Agility Multiplier: x" + Abilities.AgilityMultiplier + "  $" + price;
    }
}

