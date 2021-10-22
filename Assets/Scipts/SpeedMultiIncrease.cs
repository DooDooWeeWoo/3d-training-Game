using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedMultiIncrease : MonoBehaviour
{

    public Abilities Stats;
    public GameObject ButtonText;
    [SerializeField] int price = 100;

    void Start() 
    {
        Stats = GetComponent<Abilities>();        
    }

  public void IncreaseAgilityMulti(){
      if (Tokens.TokenVal >= price){
            Tokens.TokenVal -= price;
            price *= 5;
            Stats.AgilityMultiplier *= 2;
        }
        ButtonText.GetComponent<Text>().text = "Agility Multiplier: x" + Stats.AgilityMultiplier + "  $" + price;
    }
}

