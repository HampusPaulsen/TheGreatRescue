using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinDestroyedScore : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "PlayerBullet")
        {
           // ScoreScript.ScoreValue += 1;
            //print ("goblin collided");
        }

        // Update is called once per frame
    }
}
