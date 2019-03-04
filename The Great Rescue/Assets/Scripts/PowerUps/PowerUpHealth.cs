using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpHealth : MonoBehaviour
{
    
    private Vector2 target;
    public float speed;

    void Start()
    {
        target.x = -64;
        target.y = -2;
    }
    void Update()
    {
        if (GameObject.Find("PlayerCharacter") == null)
        {



            Destroy(gameObject);
        }
        if (BgScroll.MoveBg == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }
    }
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