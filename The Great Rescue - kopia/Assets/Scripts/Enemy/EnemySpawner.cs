﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawner : MonoBehaviour
{
    public GameObject RangedEnemy1;
    public float maxspawnrate = 5f;


    // Start is called before the first frame update
    void Start()
    {
        /* Invoke("SpawnEnemy1", 0f);
         Invoke("SpawnEnemy2", 0f);
         Invoke("SpawnEnemy3", 0f);
         Invoke("SpawnEnemy4", 0f);*/
        SpawnEnemy1();
        SpawnEnemy2();
        SpawnEnemy3();
        SpawnEnemy4();

    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
   /* void SpawnEnemy()
    {
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(1, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        GameObject anEnemy = (GameObject)Instantiate(RangedEnemy1);
        anEnemy.transform.position = new Vector2(max.x,Random.Range(min.y, max.y/2));

        Nextspawn();
    }*/

    void SpawnEnemy1()
    {
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(1, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        GameObject anEnemy = (GameObject)Instantiate(RangedEnemy1);
        anEnemy.transform.position = new Vector2(min.x,min.y/2);

       // Nextspawn();
    }
    void SpawnEnemy2()
    {
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(1, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        GameObject anEnemy = (GameObject)Instantiate(RangedEnemy1);
        anEnemy.transform.position = new Vector2(min.x, min.y / 3);

       // Nextspawn();
    }
    void SpawnEnemy3()
    {
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(1, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        GameObject anEnemy = (GameObject)Instantiate(RangedEnemy1);
        anEnemy.transform.position = new Vector2(min.x, min.y / 4);

       // Nextspawn();
    }
    void SpawnEnemy4()
    {
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(1, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        GameObject anEnemy = (GameObject)Instantiate(RangedEnemy1);
        anEnemy.transform.position = new Vector2(min.x, min.y / 5);

       // Nextspawn();
    }



  /*  void Nextspawn()
    {
        float spawn;
        if (GameObject.Find("PlayerCharacter") != null)
        {
            if (maxspawnrate > 1f)
            {
                spawn = Random.Range(1f, maxspawnrate);
            }
            else
                spawn = 1f;
            Invoke("SpawnEnemy1", spawn);
        }
    }*/


}   
