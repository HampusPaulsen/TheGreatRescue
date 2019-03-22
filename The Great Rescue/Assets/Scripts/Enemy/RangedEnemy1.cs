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
    public GameObject targ;
    public GameObject DeathSound;
    public GameObject DeathParticle;
    
    
   

    


    // Start is called before the first frame update
    void Start()
    {
       
        target = targ.transform.position;
       

    }

    // Update is called once per frame
    void Update()
    {
        position = gameObject.transform.position;
        if (GameObject.Find("PlayerCharacter") == null)
        {

           
           
            Destroy(gameObject);
        }
 
        
        if (health <= 0)
        {
             
            ScoreScript.ScoreValue += 1;
            BodyCount.Goblin += 1;
            gameObject.SendMessageUpwards("Respawn");
            DeathSound = Instantiate(DeathSound) as GameObject;
            DeathParticle = Instantiate(DeathParticle) as GameObject;
            DeathParticle.transform.position = gameObject.transform.position;
            DeathSound.transform.position = gameObject.transform.position;
            PowerUpManager.powerspawn = true;
            PowerUpManager.entitypos = position;
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
