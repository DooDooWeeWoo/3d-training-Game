using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnduranceMultiIncrease : MonoBehaviour
{
    public GameObject ButtonText;
    [SerializeField] int price = 100;
public void IncreaseEnduranceMulti(){
    if (Tokens.TokenVal >= price){
            Tokens.TokenVal -= price;
            price *= 5;
            Abilities.EnduranceMultiplier *= 2;
    }
        ButtonText.GetComponent<Text>().text = "Endurance Multiplier: x" + Abilities.EnduranceMultiplier + "  $" + price;
    }
}
