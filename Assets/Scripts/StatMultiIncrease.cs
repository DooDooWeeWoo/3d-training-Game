using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatMultiIncrease : MonoBehaviour
{
    public GameObject StatsObject; //creating a gameobject which the Stats script is connected to
    [HideInInspector]
    public Stats stat; //creating a referenceable script

    //reating a bunch of prices which will go up over time
    public int PriceE = 100;
    public int PriceS = 100;
    public int PriceP = 100;
    public int PriceA = 100;
    public GameObject PriceE_txt;
    public GameObject PriceA_txt;
    public GameObject PriceS_txt;
    public GameObject PriceP_txt; 


    void Start() //Upon Start
    {
        stat = StatsObject.GetComponent<Stats>(); //get the Stats script and allow for writing to it.
        PriceE_txt.GetComponent<Text>().text = "Endurance: x" + stat.EnduranceMulti + " Price: " + PriceE; //set the text in the inventory to show the multiplier price
        PriceS_txt.GetComponent<Text>().text = "Strength: x" + stat.StrengthMulti + " Price: " + PriceS;//
        PriceP_txt.GetComponent<Text>().text = "Psychic: x" + stat.PsychicMulti + " Price: " + PriceP;//
        PriceA_txt.GetComponent<Text>().text = "Agility: x" + stat.AgilityMulti + " Price: " + PriceA;//
    }

    public void EnduranceIncrease(){
        if (stat.Tokens>=PriceE){ //Check if the total amount of tokens the player has is more than the price
            stat.Tokens -= PriceE; //subtract the price from the total tokens
            PriceE *= 2; //double the price
            stat.EnduranceMulti *= 2; //double the multplier for the stat
            PriceE_txt.GetComponent<Text>().text = "Endurance: x" + stat.EnduranceMulti + " Price: " + PriceE; //update the text to display new price
        }
    } //repeat this process for all of the different stats

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
