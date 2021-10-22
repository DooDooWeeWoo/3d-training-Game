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
    public GameObject PowerRequiredText;
   private Abilities Stats;

    int IncreaseVal = 1;
    [SerializeField] int Multiplier = 1;
    [SerializeField] int StatRequirement = 0;

    void Start() 
    {
        Stats = GetComponent<Abilities>();        
    }
    void Update(){
        PowerRequiredText.GetComponent<TextMesh>().text = "Power Required: " + StatRequirement;
    }

    private void OnTriggerEnter(Collider other) {
        timer = 0;
        Debug.Log("Zone has been Entered");
    }
    private void OnTriggerStay(Collider other) {
        

        if (isStrength){
            if (Stats.Strength>=StatRequirement){
                timer += (Time.deltaTime/2);
                if (timer >= 1){
                    timer = 0;
                    Stats.Strength += (IncreaseVal*Multiplier*Stats.StrengthMultiplier*Stats.PrestigeMultiplier);
                }
            }
        }
        if (isAgility){
            if (Stats.Agility>=StatRequirement){
                timer += (Time.deltaTime/2);
                if (timer >= 1){
                    timer = 0;
                    Stats.Agility += (IncreaseVal*Multiplier*Stats.AgilityMultiplier*Stats.PrestigeMultiplier);
                }
            }
        }
        if (isPsychic){
            if (Stats.Psychic>=StatRequirement){
                timer += (Time.deltaTime/2);
                if (timer >= 1){
                    timer = 0;
                    Stats.Psychic += (IncreaseVal*Multiplier*Stats.PsychicMultiplier*Stats.PrestigeMultiplier);
                }
            }
        }
        if (isEndurance){
            if (Stats.Endurance>=StatRequirement){
                timer += (Time.deltaTime/2);
                if (timer >= 1){
                    timer = 0;
                    Stats.Endurance += (IncreaseVal*Multiplier*Stats.EnduranceMultiplier*Stats.PrestigeMultiplier);
                }
            }
        }
    }
    private void OnTriggerExit(Collider other) {
        Debug.Log("Zone has been Exited");
    }
}
