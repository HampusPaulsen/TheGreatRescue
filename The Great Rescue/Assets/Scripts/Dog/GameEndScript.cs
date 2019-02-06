using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEndScript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "PlayerCharacter")
        {
            GetComponent<SpriteRenderer>().color = new Color(0.85490f,  0.64706f,  0.12549f);
        }
    }
}