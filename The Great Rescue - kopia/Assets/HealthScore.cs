using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScore : MonoBehaviour
{
    public static int HealthValue= 5;
    
    Text Score;


    // Start is called before the first frame update
    void Start()
    {
        Score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("PlayerCharacter") == null)
        {
            Score.text = "Press R to restart";
        }
        else
        {
            Score.text = "HEALTH: " + HealthValue;
        }
    }
}