using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultishotPowerUp : MonoBehaviour
{
    private Vector2 target;
    public float speed;

    void Start()
    {
        GameObject player = GameObject.Find("PlayerCharacter");

        target = player.transform.position;
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
            Destroy(gameObject);
        }
    }
}
