using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn1 : MonoBehaviour
{
    [SerializeField]
    //private int loc = 1;
    public GameObject Enemy;
    public int spawncap = 0;
    int spawned= 0;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy1();

    }

    // Update is called once per frame
    void Update()
    {
  
    }
    void Respawn()
    {
        while (spawncap > spawned)
        {
            spawned++;
            SpawnEnemy1();
        }
    }


    void SpawnEnemy1()
    {
       // Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(1, 0));
     //   Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        GameObject anEnemy = (GameObject)Instantiate(Enemy);
        anEnemy.transform.position = gameObject.transform.position;
        anEnemy.transform.parent = gameObject.transform;


    }
}
