using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Abilities : MonoBehaviour
{
    public GameObject AgilityText;
    public GameObject StrengthText;
    public GameObject PsychicText;
    public GameObject EnduranceText;
    public GameObject TotalPowerText;

    public int AgilityMultiplier = 1;
    public int StrengthMultiplier = 1;
    public int PsychicMultiplier = 1;
    public int EnduranceMultiplier = 1;

    public int Strength = 1;
    public int Agility = 1;
    public int Endurance = 1;
    public int Psychic = 1;
    public int TotalPower;
    
    public int PrestigeMultiplier = 1;
    public int prestige;
    

    void Update()
    {
        TotalPower = (Agility+Strength+Endurance+Psychic);

        PlayerController.walkSpeed = Agility/10000;
        PlayerController.JumpStrength = (Agility+Strength)/10000;
        ObstaclePush.forceMagnitude = (Strength/10);
        
        AgilityText.GetComponent<Text>().text = "Agility: " + Agility;
        StrengthText.GetComponent<Text>().text = "Strength: " + Strength;
        PsychicText.GetComponent<Text>().text = "Psychic: " + Psychic;
        EnduranceText.GetComponent<Text>().text = "Endurance: " + Endurance;
        TotalPowerText.GetComponent<Text>().text = "Total Power: " + TotalPower;
    }
}
