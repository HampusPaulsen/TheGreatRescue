using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeTransparent : MonoBehaviour {

    // Use this for initialization
    

    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = false;

    }
}
