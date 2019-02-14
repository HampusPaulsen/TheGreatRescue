using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpHealth : MonoBehaviour
{
    public float PlayerHealth;
    void OnCollisionEnter2D(Collision2D col)
    {
        //checks if colliding with something named PlayerCharacter
        if (col.gameObject.name == "PlayerCharacter")
        {
            //if true then does this
            
            //randomly changes color just so we can see it works multiple times and also its kinda fun
            col.gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            //prints in console what it collides with 4 testing
            print("Power-Up collided with: " + col.gameObject.name);

            //kinda explains itself
            if (PlayerHealth < 5)
            {
                PlayerHealth = PlayerHealth +1;
            }

        }
    }
}