using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour
{
    public GameObject EnemyBulletGO;
    int timer = 0;
    public int firerate;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("FireEnemyBullet", 1f);
        
    }

    // Update is called once per frame
    void Update()
    {
        timer++;
        if (timer == firerate)
        {
            Invoke("FireEnemyBullet", 2f);
            timer = 0;
        }
          

    }
    void FireEnemyBullet()
    {
        GameObject player = GameObject.Find("PlayerCharacter");
        if (player != null)
        {
            GameObject bullet = (GameObject)Instantiate(EnemyBulletGO);
            bullet.transform.position = transform.position;
            Vector2 direction = player.transform.position - bullet.transform.position;
            bullet.GetComponent<EnemyBullet>().SetDirection(direction);

        }
    }
}

