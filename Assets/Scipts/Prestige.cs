using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Prestige : MonoBehaviour
{

    public GameObject PrestigeText;

    public void IncreasePrestigeMulti(){

        Abilities.PrestigeMultiplier *= 2;
        Tokens.tokenMultiplier *= 2;
        PrestigeText.GetComponent<Text>().text = "Reputation Multiplier: x" + Abilities.PrestigeMultiplier;

    }
}
