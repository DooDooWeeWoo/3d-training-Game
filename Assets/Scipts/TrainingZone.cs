using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainingZone : MonoBehaviour
{
    float timer;
    public bool Psychic;
    public bool Strength;
    public bool Endurance;
    public bool Agility;
    
    public GameObject StatsObject;
    [HideInInspector]
    public Stats stat;
    [SerializeField] int statRequirement;
    public int ZoneMulti;
    

    void Start()
    {
        stat = StatsObject.GetComponent<Stats>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered Training Zone");
        timer = 0;
    }

    private void OnTriggerStay(Collider other)
    {

        
        if (Endurance){
            if(stat.Endurance>=statRequirement){
                timer += Time.deltaTime;
                if(timer>1){
                    timer = 0;
                    stat.Endurance += (ZoneMulti*stat.EnduranceMulti*stat.PrestigeMulti);
                }
            }
        }

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
