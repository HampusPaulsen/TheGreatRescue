using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : MonoBehaviour
{


    private Vector2 target;
    private Vector2 position;
    public float speed;
    public int health = 2;
    private float direction;
    public GameObject PowerUp;
 
   





    // Start is called before the first frame update
    void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("PlayerCharacter") == null)
        {

            

            Destroy(gameObject);
        }
        if (health <= 0)
        {
            if (Random.Range(1, 13) == 3)
            {
                PowerUp = Instantiate(PowerUp) as GameObject;
                PowerUp.transform.position = gameObject.transform.position;
            }
            ScoreScript.ScoreValue += 1;
            BodyCount.Orc += 1;
            gameObject.SendMessageUpwards("Respawn");
            Destroy(gameObject);
        }
        GameObject player = GameObject.Find("PlayerCharacter");
        target = player.transform.position;
        position = gameObject.transform.position;
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