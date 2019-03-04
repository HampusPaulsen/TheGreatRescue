using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyOnInvisible : MonoBehaviour
{
    // Use this for initialization
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Boundary")
        {
            if (gameObject.name == "BulletPrefab(Clone)")
            {
                Destroy(gameObject);
            }
        }
    }



}
