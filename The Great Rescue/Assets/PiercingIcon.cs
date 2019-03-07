using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PiercingIcon : MonoBehaviour
{
  
    Text Piercing;


    // Start is called before the first frame update
    void Start()
    {
        Piercing = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerScript.pierceshot == true)
        {
           Piercing.text = "PIERCING"; 
        }
        else
        {
           Piercing.text = " ";
        }
    }
}