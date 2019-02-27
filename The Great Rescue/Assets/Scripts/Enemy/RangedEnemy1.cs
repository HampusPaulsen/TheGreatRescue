using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedEnemy1 : MonoBehaviour
{

   
    private Vector2 target;
    private Vector2 position;
    public float speed;
    public int health = 1;
    private float direction;
    public GameObject PowerUp;
    public GameObject targ;
    public GameObject WaveManager;
    public Wavemanager wave;
    
   

    


    // Start is called before the first frame update
    void Start()
    {
        
        // target = new Vector2(Random.Range(5,15), Random.Range(5, -10));
        target = targ.transform.position;
        position = gameObject.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("PlayerCharacter") == null)
        {

            WaveManager.GetComponent<Wavemanager>().bodycount= 25;
           
            Destroy(gameObject);
        }
        if (health == 0)
        {
            if(Random.Range(1,13)==3)
            {
                PowerUp = Instantiate(PowerUp) as GameObject;
                PowerUp.transform.position = gameObject.transform.position;
            }
            ScoreScript.ScoreValue += 1;
            Destroy(gameObject);
        }
            
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        

      
    }
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.name == "BulletPrefab(Clone)")
        {

            health--;
        }
    }
} 
