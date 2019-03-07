using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawner : MonoBehaviour
{
    public GameObject Shrek;
    public float spawndelay = 5.0f;
    public int maxspawn = 1;
    private int spawned = 0;
    public float timeactual = 5.0f;


    // Start is called before the first frame update
    void Start()
    {
        timeactual = spawndelay;

    }

    // Update is called once per frame
    void Update()
    {
        
        while (spawned < maxspawn)
        {
            timeactual -= Time.deltaTime;

            if (timeactual <= 0.0f)
            {
                SpawnEnemy();
                spawned++;
                timeactual = spawndelay;
            }
        }
        


    }
    void SpawnEnemy()
    {
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(1, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        GameObject anEnemy = (GameObject)Instantiate(Shrek);
        anEnemy.transform.position = new Vector2(max.x,Random.Range(min.y, max.y/2));
      

      
    }

   /* void SpawnEnemy1()
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
    }*/




}   
