using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedEnemy2 : MonoBehaviour
{


    private Vector2 target;
    private Vector2 position;
    public float speed;
    public int health = 3;
    private float direction;
    public GameObject PowerUp1;
    public GameObject PowerUp2;
    public GameObject targ;
    public GameObject DeathSound;
    private int pick;







    // Start is called before the first frame update
    void Start()
    {

        pick = Random.Range(1, 3);
        target = targ.transform.position;
        position = gameObject.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("PlayerCharacter") == null)
        {



            Destroy(gameObject);
        }

        if (pick == 1)
        {
            if (health == 0 && health < 5)
            {
                if (Random.Range(1, 10) == 3)
                {
                    PowerUp1 = Instantiate(PowerUp1) as GameObject;
                    PowerUp1.transform.position = gameObject.transform.position;
                }
                ScoreScript.ScoreValue += 1;
                BodyCount.Troll += 1;
                gameObject.SendMessageUpwards("Respawn");
                DeathSound = Instantiate(DeathSound) as GameObject;
                DeathSound.transform.position = gameObject.transform.position;
                Destroy(gameObject);
            }
        }
        if(pick == 2)
        {
            if (health == 0)
            {
                if (Random.Range(1, 15) == 3)
                {
                    PowerUp2 = Instantiate(PowerUp2) as GameObject;
                    PowerUp2.transform.position = gameObject.transform.position;
                }
                ScoreScript.ScoreValue += 1;
                BodyCount.Troll += 1;
                gameObject.SendMessageUpwards("Respawn");
                DeathSound = Instantiate(DeathSound) as GameObject;
                DeathSound.transform.position = gameObject.transform.position;
                Destroy(gameObject);
            }
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
