using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Prestige : MonoBehaviour
{

    public GameObject PrestigeText;
    int TotalPowerRequirement;

    public void IncreasePrestigeMulti(){

        if (Abilities.TotalPower>TotalPowerRequirement){
            Abilities.Psychic = 0;
            Abilities.Endurance = 0;
            Abilities.Agility = 0;
            Abilities.Strength = 0;
            Abilities.PrestigeMultiplier *= 2;
            Tokens.tokenMultiplier *= 2;
            PrestigeText.GetComponent<Text>().text = "Reputation Multiplier: x" + Abilities.PrestigeMultiplier;
            PrestigeText.GetComponent<Text>().text = "Required Total Power: " + TotalPowerRequirement;
        }
    }
}
