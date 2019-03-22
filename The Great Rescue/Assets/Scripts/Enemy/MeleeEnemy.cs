﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : MonoBehaviour
{


    private Vector2 target;
    private Vector2 position;
    public float speed;
    public int health = 2;
    private float direction;
    public GameObject DeathSound;
    public GameObject DeathParticle;
    public float colortime = 0.5f;
    private float time = 0;
    private bool changecolor = false;







    // Start is called before the first frame update
    void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {
        if (changecolor == true)
        {
            time += Time.deltaTime;
            GetComponent<SpriteRenderer>().color = new Color(255, 0, 0, 255);
            if (time >= colortime)
            {
                time = 0;
                changecolor = false;
                GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
            }
        }
        if (GameObject.Find("PlayerCharacter") == null)
        {

            

            Destroy(gameObject);
        }
        if (health <= 0)
        {
          
            ScoreScript.ScoreValue += 1;
            BodyCount.Orc += 1;
            gameObject.SendMessageUpwards("Respawn");
            DeathSound = Instantiate(DeathSound) as GameObject;
            DeathParticle = Instantiate(DeathParticle) as GameObject;
            DeathParticle.transform.position = gameObject.transform.position;
            DeathSound.transform.position = gameObject.transform.position;
            PowerUpManager.powerspawn = true;
            PowerUpManager.entitypos = position;
            Destroy(gameObject);
        }
        GameObject player = GameObject.Find("PlayerCharacter");
        target = player.transform.position;
        position = gameObject.transform.position;
        if(target.x <= position.x -10||target.y>=position.y+20|| target.y <= position.y - 20||target.x>=position.x +10)
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);



    }
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.name == "BulletPrefab(Clone)")
        {
            changecolor = true;
            health--;
        }
    }
}