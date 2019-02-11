using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyGun : MonoBehaviour
{
    public GameObject EnemyBulletGO;
    float time;
    public float firerate;
  


    // Start is called before the first frame update
    void Start()
    {
        Invoke("FireEnemyBullet", 1f);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= firerate)
        {
            time = 0;
            Invoke("FireEnemyBullet", 2f);
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

