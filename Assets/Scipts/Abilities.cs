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

    public static int AgilityMultiplier = 1;
    public static int StrengthMultiplier = 1;
    public static int PsychicMultiplier = 1;
    public static int EnduranceMultiplier = 1;

    public static int Strength = 1;
    public static int Agility = 1;
    public static int Endurance = 1;
    public static int Psychic = 1;
    public static int TotalPower;
    
    public static int PrestigeMultiplier = 1;

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
