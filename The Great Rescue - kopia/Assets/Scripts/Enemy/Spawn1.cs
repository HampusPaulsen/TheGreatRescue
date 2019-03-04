using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn1 : MonoBehaviour
{
    [SerializeField]
    //private int loc = 1;
    public GameObject RangedEnemy1;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy1();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnEnemy1()
    {
       // Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(1, 0));
     //   Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        GameObject anEnemy = (GameObject)Instantiate(RangedEnemy1);
        anEnemy.transform.position = gameObject.transform.position;

    
    }
}
