using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    AudioSource m_MyAudioSource;
    public static int health = 5;

    [SerializeField]
    private float speed = 3.0f; //Change this to change the speed of the player character

    private Vector2 direction;
    private Vector2 orgpos;
    void Die()
    {

        Destroy(gameObject);
    }

    void Start() 
    {
        orgpos.x = -64;
        orgpos.y = -2;
        m_MyAudioSource = GetComponent<AudioSource>();
    }

    void Update() //Calls functions once per frame
    {
        if (health > 5)
        {
            health = 5;
        }
        if (health == 0)
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
        {
            direction += Vector2.up;
        }

        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;
        }

        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector2.down;
        }

        if (Input.GetKey(KeyCode.D))
        {
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
        if (col.gameObject.name == "RangedEnemy1(Clone)")
        {
            HealthScore.HealthValue -= 1;
            m_MyAudioSource.Play();
            health--;
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
    }

}
