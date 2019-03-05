using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyOnInvisibleEnemyBullet : MonoBehaviour
{
    // Use this for initialization
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Boundary")
        {
            if (gameObject.name == "EnemyBulletGO(Clone)")
            {
                Destroy(gameObject);
            }
        }
    }
}
