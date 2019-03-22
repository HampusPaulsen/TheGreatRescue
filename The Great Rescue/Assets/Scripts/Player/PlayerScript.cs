using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    AudioSource m_MyAudioSource;
    public static int health = 5;
    public static bool pierceshot = false;

    public float piercingtime = 5f;
    private float timeelapsed = 0;

    public GameObject top;
    public GameObject left;
    public GameObject right;
    public GameObject bottom;

    private Vector2 topb;
    private Vector2 leftb;
    private Vector2 rightb;
    private Vector2 bottomb;
    private Vector2 playerpos;

    [SerializeField]
    private float speed = 3.0f; //Change this to change the speed of the player character

    Transform PlayerManager;

    private Vector2 direction;
    private Vector2 orgpos;
    void Die()
    {

        Destroy(gameObject);
    }

    void Start() 
    {
        topb = top.transform.position;
        bottomb = bottom.transform.position;
        rightb = right.transform.position;
        leftb = left.transform.position;

        orgpos.x = -64;
        orgpos.y = -2;
        m_MyAudioSource = GetComponent<AudioSource>();
    }

    void Awake()
    {
        PlayerManager = transform.Find("PlayerManager");
    }

    void Update() //Calls functions once per frame
    {
        playerpos = gameObject.transform.position;
        if (pierceshot == true)
        {
            PlayerBullet.pierce = true;
            timeelapsed += Time.deltaTime;
            if (timeelapsed >= piercingtime)
            {
                pierceshot = false;
                PlayerBullet.pierce = false;
                timeelapsed = 0;
            }
            
        }
        if (health > 5)
        {
            health = 5;
        }
        if (health <= 0)
        {

            m_MyAudioSource.Play();
            Die();


        }
        //if (BgScroll.MoveBg == false)
        //{
      GetInput();
     PlayerMovement();
        //}
        //if (BgScroll.MoveBg == true)
       // {
     //gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, orgpos, 70 * Time.deltaTime);
        //}
    }


    private void GetInput()
    {
        direction = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        { if(playerpos.y<=topb.y-12)
            direction += Vector2.up;
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (playerpos.x >= leftb.x + 11)
                direction += Vector2.left;
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (playerpos.y >= bottomb.y + 15)
                direction += Vector2.down;
        }

        if (Input.GetKey(KeyCode.D))
        {
           if (playerpos.x <= rightb.x - 12)
            direction += Vector2.right;
        }
    }

    public void PlayerMovement()
    {
        //This will move the player according to their direction * speed * time in seconds
        transform.Translate(direction * speed * Time.deltaTime);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        //checks if colliding with enemies
        if (col.gameObject.tag == "RangedEnemy1")
        {
            HealthScore.HealthValue -= 1;
            m_MyAudioSource.Play();
            health--;
        }
        //checks if colliding with piercing powerup
        if (col.gameObject.tag == "piercing")
        {
            pierceshot = true;
        }

            //checks if colliding with Enemy Bullets
            if (col.gameObject.name == "EnemyBulletGO(Clone)")
        {
            HealthScore.HealthValue -= 1;
            m_MyAudioSource.Play();
            health--;
        }
        //checks is colliding with enemy hurtbox
        if (col.gameObject.tag == "pointy")
        {
            HealthScore.HealthValue -= 1;
            m_MyAudioSource.Play();
            health--;
           
        }
    
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "laser")
        {
            HealthScore.HealthValue -= 1;
            m_MyAudioSource.Play();
            health--;

        }
        if (col.gameObject.tag == "RangedEnemy1")
        {
            HealthScore.HealthValue -= 1;
            m_MyAudioSource.Play();
            health--;
        }
    }

}
