using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    [SerializeField]
    private float bulletVelocity = 10;

    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * bulletVelocity);
        //  Destroy();
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.tag == "RangedEnemy1")
        {
          
            Destroy(gameObject);
        }
      
    }
}
