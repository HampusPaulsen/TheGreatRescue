using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceholderPlayerBulletScript : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D col)
    {
        //checks if colliding with something named PlayerCharacter
        if (col.gameObject.tag == "RangedEnemy1")
        {
            {

                //prints in console what it collides with 4 testing
                print("Player arrow collided with: " + col.gameObject.name);
                Destroy(col.gameObject);



            }
        }
    }
}