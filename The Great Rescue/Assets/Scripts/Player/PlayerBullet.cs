using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    [SerializeField]
    public float bulletVelocity;
    public static bool pierce = false;
<<<<<<< HEAD
=======
    private int pierced = 0;
    AudioSource m_MyAudioSource;
    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
    }
>>>>>>> Newmasterdon'tfuckthisup

    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * bulletVelocity);
        //  Destroy();
    }
   
    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.tag == "RangedEnemy1")
        {
<<<<<<< HEAD
=======
            m_MyAudioSource.Play();
            pierced++;
>>>>>>> Newmasterdon'tfuckthisup
            if(pierce ==false)
            { Destroy(gameObject); }
        }
      
    }
}
