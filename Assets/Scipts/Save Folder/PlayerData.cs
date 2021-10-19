using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData{

    public int AgilityMultiplier;
    public int StrengthMultiplier;
    public int PsychicMultiplier;
    public int EnduranceMultiplier;

    public int Strength;
    public int Agility;
    public int Endurance;
    public int Psychic;

    public int prestige;
    public int PrestigeMultiplier;

    public int tokens;
    public int TokensMultiplier;


    public PlayerData (PlayerController player){

        AgilityMultiplier = Abilities.AgilityMultiplier;
        StrengthMultiplier = Abilities.StrengthMultiplier;
        PsychicMultiplier = Abilities.PsychicMultiplier;
        EnduranceMultiplier = Abilities.EnduranceMultiplier;

        Strength = Abilities.Strength;
        Agility = Abilities.Agility;
        Psychic = Abilities.Psychic;
        Endurance = Abilities.Endurance;

        prestige = Abilities.prestige;
        PrestigeMultiplier = Abilities.PrestigeMultiplier;

       tokens = Tokens.TokenVal;
        TokensMultiplier = Tokens.tokenMultiplier;
    }
}

