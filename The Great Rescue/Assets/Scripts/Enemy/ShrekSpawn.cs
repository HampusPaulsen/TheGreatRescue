using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrekSpawn : MonoBehaviour
{
    public GameObject Shrek;
    public float spawndelay = 5.0f;
    public float TimeElapsed;
    private int size=0;
    public int cap;

    // Start is called before the first frame update
    void Start()
    {
        TimeElapsed = 0.0f;
        //StartCoroutine("spawner");
    }

    // Update is called once per frame
    void Update()
    {



        if (size < cap)
        {

            timer();

            
        }


    }
    void SpawnEnemy()
    {
        ScreenShake.shakeDuration = 2;
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(1, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        GameObject anEnemy = (GameObject)Instantiate(Shrek);
        anEnemy.transform.position = new Vector2(max.x, Random.Range(min.y, max.y / 2));
    


    }
    void timer()
    {
        TimeElapsed += Time.deltaTime;
       
        if (TimeElapsed >= spawndelay)
        {
            
            SpawnEnemy();
            TimeElapsed = 0f;
            size++;
        }
    }

   /* IEnumerator spawner()
    {
  
        while(size < cap)
        {


            timer();
            size++;
            yield return null;
        }
    }*/
}
