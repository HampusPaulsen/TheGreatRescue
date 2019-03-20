using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PiercingIcon : MonoBehaviour
{
  
    
    [SerializeField]
    public Renderer Rend1;

    // Start is called before the first frame update
    void Start()
    {
       
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