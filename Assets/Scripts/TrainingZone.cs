using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainingZone : MonoBehaviour
{
    float timer; //create a float variable for the timer
    //create a few true or false variables so that the developer can adjust what zone type they want to use in the unity editor
    public bool Psychic; 
    public bool Strength;
    public bool Endurance;
    public bool Agility;
    
    public GameObject StatsObject;
    [HideInInspector]
    public Stats stat;
    [SerializeField] int statRequirement; //create a stat requirement so that the player has to have a certain level in a stat
    public int ZoneMulti;
    

    void Start()
    {
        stat = StatsObject.GetComponent<Stats>();
    }

    private void OnTriggerEnter(Collider other) //upon entering the training zone
    {
        Debug.Log("Entered Training Zone"); //type into the log
        timer = 0; //set the timer to zero
    }

    private void OnTriggerStay(Collider other) //while staying in the training zone
    {
        //check what bool the developer set the training zone to
        if (Endurance){ 
            if(stat.Endurance>=statRequirement){ //check if the player has the minimum required stat to use the zone
                timer += Time.deltaTime; //start the timer
                if(timer>1){ //upon every second
                    timer = 0; //set the timer to zero
                    stat.Endurance += (ZoneMulti*stat.EnduranceMulti*stat.PrestigeMulti); //increase the players stat by the zone multiplier(5 for example) * the stat multiplier * the prestige multiplier
                }
            }
        } //repeat the process with the other stats

        if (Strength){
            if(stat.Strength>=statRequirement){
                timer += Time.deltaTime;
                if(timer>1){
                    timer = 0;
                    stat.Strength += (ZoneMulti*stat.StrengthMulti*stat.PrestigeMulti);
                }
            }
        }

        if (Psychic){
            if(stat.Psychic>=statRequirement){
                timer += Time.deltaTime;
                if(timer>1){
                    timer = 0;
                    stat.Psychic += (ZoneMulti*stat.PsychicMulti*stat.PrestigeMulti);
                }
            }
        }

        if (Agility){
            if(stat.Agility>=statRequirement){
                timer += Time.deltaTime;
                if(timer>1){
                    timer = 0;
                    stat.Agility += (ZoneMulti*stat.AgilityMulti*stat.PrestigeMulti);
                }
            }
        }


        


    }


}
