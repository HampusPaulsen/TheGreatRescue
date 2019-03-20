﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PiercingIcon : MonoBehaviour
{
  
    Text Piercing;
    public Renderer Rend1;

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
            Rend1.enabled = true;
        }

        else
        {
            Rend1.enabled = false;
        }
        
    }
}