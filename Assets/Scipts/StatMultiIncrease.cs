using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatMultiIncrease : MonoBehaviour
{
    public GameObject StatsObject;
    [HideInInspector]
    public Stats stat;

    public int PriceE = 100;
    public int PriceS = 100;
    public int PriceP = 100;
    public int PriceA = 100;
    public GameObject PriceE_txt;
    public GameObject PriceA_txt;
    public GameObject PriceS_txt;
    public GameObject PriceP_txt; 

    void Start()
    {
        stat = StatsObject.GetComponent<Stats>();
        PriceE_txt.GetComponent<Text>().text = "Endurance: x" + stat.EnduranceMulti + " Price: " + PriceE;
        PriceS_txt.GetComponent<Text>().text = "Strength: x" + stat.StrengthMulti + " Price: " + PriceS;
        PriceP_txt.GetComponent<Text>().text = "Psychic: x" + stat.PsychicMulti + " Price: " + PriceP;
        PriceA_txt.GetComponent<Text>().text = "Agility: x" + stat.AgilityMulti + " Price: " + PriceA;
    }

    void Update(){

    }

    public void EnduranceIncrease(){
        if (stat.Tokens>=PriceE){
            stat.Tokens -= PriceE;
            PriceE *= 2;
            stat.EnduranceMulti *= 2;
            PriceE_txt.GetComponent<Text>().text = "Endurance: x" + stat.EnduranceMulti + " Price: " + PriceE;
        }
    }

    public void StrengthIncrease(){
        if (stat.Tokens>=PriceS){
            stat.Tokens -= PriceS;
            PriceS *= 2;
            stat.StrengthMulti *= 2;
            PriceS_txt.GetComponent<Text>().text = "Strength: x" + stat.StrengthMulti + " Price: " + PriceS;
        }
    }

    public void PsychicIncrease(){
        if (stat.Tokens>=PriceP){
            stat.Tokens -= PriceP;
            PriceP *= 2;
            stat.PsychicMulti *= 2;    
            PriceP_txt.GetComponent<Text>().text = "Psychic: x" + stat.PsychicMulti + " Price: " + PriceP;
        }
    }

    public void AgilityIncrease(){
        if (stat.Tokens>=PriceA){
            stat.Tokens -= PriceA;
            PriceA *= 1;
            stat.AgilityMulti *= 2;
            PriceA_txt.GetComponent<Text>().text = "Agility: x" + stat.AgilityMulti + " Price: " + PriceA;
        }
    }
}
