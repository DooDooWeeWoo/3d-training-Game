using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Prestige : MonoBehaviour
{

    public GameObject PrestigeText;
    public GameObject PowerRequirementText;
    public int TotalPowerRequirement = 100000;
    public Abilities Stats;

    void Start() 
    {
        Stats = GetComponent<Abilities>();        
    }
  
    public void IncreasePrestigeMulti(){

        if (Stats.TotalPower>TotalPowerRequirement){
            TotalPowerRequirement *= 100;
            Stats.Psychic = 0;
            Stats.Endurance = 0;
            Stats.Agility = 0;
            Stats.Strength = 0;
            Stats.prestige++;
            Stats.PrestigeMultiplier *= 2;
            
            Tokens.tokenMultiplier *= 2;
            PrestigeText.GetComponent<Text>().text = "Reputation Multiplier: x" + Stats.PrestigeMultiplier;
            PowerRequirementText.GetComponent<Text>().text = "Required Total Power: " + TotalPowerRequirement;
        }
    }
}
