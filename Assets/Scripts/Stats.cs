using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    //create "stat" variables which the script will be able to pass out to other scripts
    public int Strength; //strength stat
    public int Agility; //agility stat
    public int Psychic; //psychic stat
    public int Endurance; //endurance stat

    //create multipliers for the stats which the script can pass out to other scripts
    public int StrengthMulti = 1; //strength multiplier stat
    public int AgilityMulti = 1; //agility multiplier stat
    public int PsychicMulti = 1; //psychic multiplier stat
    public int EnduranceMulti = 1; //enduance multiplier stat

    //create a prestige stat and prestige multiplier(currently does nothing)(do not remove)
    public int Prestige = 1;
    public int PrestigeMulti = 1;

    //create a tokens stat and a tokens multiplier stat
    public int Tokens; //tokens or money which the player can spend
    public int TokenMultiplier = 1; //Mltiplier for the amount of tokens the player gets every 15 seconds

    public int TotalPower; //the sum of the Strength, Endurance, Psychic, Agility stats

    //create texxt gameobjects for the different stats
    public GameObject StrengthTXT;
    public GameObject EnduranceTXT;
    public GameObject PsychicTXT;
    public GameObject AgilityTXT;
    public GameObject TotalPowerTXT;
    public GameObject TokensTXT;

    void Update(){
        TotalPower = (Strength+Agility+Psychic+Endurance); //sum the stats together

        //update the stat texts
        StrengthTXT.GetComponent<Text>().text = "Strength: " + Strength;
        EnduranceTXT.GetComponent<Text>().text = "Endurance: " + Endurance;
        PsychicTXT.GetComponent<Text>().text = "Psychic: " + Psychic;
        AgilityTXT.GetComponent<Text>().text = "Agility: " + Agility;
        TotalPowerTXT.GetComponent<Text>().text = "Total Power: " + TotalPower;
        TokensTXT.GetComponent<Text>().text = "Tokens: " + Tokens;
    }

    public void SavePlayer() //run the save player function(from a button)
    {
        SaveSystem.SavePlayer(this); //pass the requiredd variables to save player(Shown in save player script)
    }
    public void LoadPlayer() //run the load player function(from a button)
    {
        PlayerData data = SaveSystem.LoadPlayer(); //grab the required variables from the PlayerData save file

        //Overwrite all the variables with their matching stats
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
