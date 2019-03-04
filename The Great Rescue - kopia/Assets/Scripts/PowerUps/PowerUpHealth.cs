using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpHealth : MonoBehaviour
{
    
    
    void OnCollisionEnter2D(Collision2D col)
    {
        //checks if colliding with something named PlayerCharacter
        if (col.gameObject.name == "PlayerCharacter")
        {
                PlayerScript.health++;
                HealthScore.HealthValue += 1;
            Destroy(gameObject);





        }
    }
}