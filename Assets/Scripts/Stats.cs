using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    public int Strength;
    public int Agility;
    public int Psychic;
    public int Endurance;

    public int StrengthMulti = 1;
    public int AgilityMulti = 1;
    public int PsychicMulti = 1;
    public int EnduranceMulti = 1;

    public int Prestige = 1;
    public int PrestigeMulti = 1;

    public int Tokens;
    public int TokenMultiplier = 1;

    public int TotalPower; 

    public GameObject StrengthTXT;
    public GameObject EnduranceTXT;
    public GameObject PsychicTXT;
    public GameObject AgilityTXT;
    public GameObject TotalPowerTXT;
    public GameObject TokensTXT;

    void Update(){
        TotalPower = (Strength+Agility+Psychic+Endurance);

        StrengthTXT.GetComponent<Text>().text = "Strength: " + Strength;
        EnduranceTXT.GetComponent<Text>().text = "Endurance: " + Endurance;
        PsychicTXT.GetComponent<Text>().text = "Psychic: " + Psychic;
        AgilityTXT.GetComponent<Text>().text = "Agility: " + Agility;
        TotalPowerTXT.GetComponent<Text>().text = "Total Power: " + TotalPower;
        TokensTXT.GetComponent<Text>().text = "Tokens: " + Tokens;
    }
    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        Strength = data.Strength;
        Endurance = data.Endurance;
        Agility = data.Agility;
        Psychic = data.Psychic;

        StrengthMulti = data.StrengthMulti;
        EnduranceMulti = data.EnduranceMulti;
        AgilityMulti = data.AgilityMulti;
        PsychicMulti = data.PsychicMulti;

        Prestige = data.Prestige;
        PrestigeMulti = data.PrestigeMulti;

        Tokens = data.Tokens;
        TokenMultiplier = data.TokenMultiplier;
    }

}
