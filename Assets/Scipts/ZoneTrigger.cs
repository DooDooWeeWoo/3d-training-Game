using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoneTrigger : MonoBehaviour
{
    float timer;

    public bool isAgility;
    public bool isStrength;
    public bool isPsychic;
    public bool isEndurance;

    int IncreaseVal = 1;
    [SerializeField] int Multiplier = 1;
    [SerializeField] int StatRequirement = 0;


    private void OnTriggerEnter(Collider other) {
        timer = 0;
        Debug.Log("Zone has been Entered");
    }
    private void OnTriggerStay(Collider other) {
        

        if (isStrength){
            if (Abilities.Strength>=StatRequirement){
                timer += (Time.deltaTime/2);
                if (timer >= 1){
                    timer = 0;
                    Abilities.Strength += (IncreaseVal*Multiplier*Abilities.StrengthMultiplier*Abilities.PrestigeMultiplier);
                }
            }
        }
        if (isAgility){
            if (Abilities.Agility>=StatRequirement){
                timer += (Time.deltaTime/2);
                if (timer >= 1){
                    timer = 0;
                    Abilities.Agility += (IncreaseVal*Multiplier*Abilities.AgilityMultiplier*Abilities.PrestigeMultiplier);
                }
            }
        }
        if (isPsychic){
            if (Abilities.Psychic>=StatRequirement){
                timer += (Time.deltaTime/2);
                if (timer >= 1){
                    timer = 0;
                    Abilities.Psychic += (IncreaseVal*Multiplier*Abilities.PsychicMultiplier*Abilities.PrestigeMultiplier);
                }
            }
        }
        if (isEndurance){
            if (Abilities.Endurance>=StatRequirement){
                timer += (Time.deltaTime/2);
                if (timer >= 1){
                    timer = 0;
                    Abilities.Endurance += (IncreaseVal*Multiplier*Abilities.EnduranceMultiplier*Abilities.PrestigeMultiplier);
                }
            }
        }
    }
    private void OnTriggerExit(Collider other) {
        Debug.Log("Zone has been Exited");
    }
}
