using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Prestige : MonoBehaviour
{

    public GameObject PrestigeText;
    public GameObject PowerRequirementText;
    public int TotalPowerRequirement = 100000;
  

    public void IncreasePrestigeMulti(){

        if (Abilities.TotalPower>TotalPowerRequirement){
            TotalPowerRequirement *= 100;
            Abilities.Psychic = 0;
            Abilities.Endurance = 0;
            Abilities.Agility = 0;
            Abilities.Strength = 0;
            Abilities.prestige++;
            Abilities.PrestigeMultiplier *= 2;
            
            Tokens.tokenMultiplier *= 2;
            PrestigeText.GetComponent<Text>().text = "Reputation Multiplier: x" + Abilities.PrestigeMultiplier;
            PowerRequirementText.GetComponent<Text>().text = "Required Total Power: " + TotalPowerRequirement;
        }
    }
}
