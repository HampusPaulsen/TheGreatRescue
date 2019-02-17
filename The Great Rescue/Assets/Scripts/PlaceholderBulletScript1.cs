using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceholderBulletScript : MonoBehaviour
{
   
    void OnCollisionEnter2D(Collision2D col)
    {
        //checks if colliding with something named PlayerCharacter
        
            //if true then does this

            //randomly changes color just so we can see it works multiple times and also its kinda fun
            Destroy(col.gameObject);
            //prints in console what it collides with 4 testing
            

            //kinda explains itself
          

        
    }
}
