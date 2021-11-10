using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class PlayerData
{

    public int Strength;
    public int Agility;
    public int Psychic;
    public int Endurance;

    public int StrengthMulti;
    public int AgilityMulti;
    public int PsychicMulti;
    public int EnduranceMulti;

    public int Prestige;
    public int PrestigeMulti;

    public int Tokens;
    public int TokenMultiplier;

    public PlayerData (Stats stats)
    {
        Strength = stats.Strength;
        Endurance = stats.Endurance;
        Agility = stats.Agility;
        Psychic = stats.Psychic;

        StrengthMulti = stats.StrengthMulti;
        EnduranceMulti = stats.EnduranceMulti;
        AgilityMulti = stats.AgilityMulti;
        PsychicMulti = stats.PsychicMulti;

        Prestige = stats.Prestige;
        PrestigeMulti = stats.PrestigeMulti;

        Tokens = stats.Tokens;
        TokenMultiplier = stats.TokenMultiplier;
    }
}
