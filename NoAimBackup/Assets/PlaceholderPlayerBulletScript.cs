using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class PlaceholderPlayerBulletScript : MonoBehaviour
{
    
 
    void OnCollisionEnter2D(Collision2D col)
    {
        //checks if colliding with something named PlayerCharacter
        if (col.gameObject.tag == "RangedEnemy1")
        {


            //Score.text = "Score: " + ScoreValue;
            {
                Destroy(col.gameObject);
                ScoreScript.ScoreValue += 1;
            }
        }
    }
}