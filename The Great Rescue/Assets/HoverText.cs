using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverText : MonoBehaviour
{

    public Renderer menuObject;

    void OnMouseEnter()
    {
        menuObject.enabled = true;
    }
    void OnMouseExit()
    {

        menuObject.enabled = false;
    }
}