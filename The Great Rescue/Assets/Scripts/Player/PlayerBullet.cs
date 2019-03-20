using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    [SerializeField]
    public float bulletVelocity;
    public static bool pierce = false;
    private int pierced = 0;
    AudioSource m_MyAudioSource;
    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * bulletVelocity);
        //  Destroy();
    }
   
    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.tag == "RangedEnemy1"|| col.gameObject.tag == "orc")
        {
            m_MyAudioSource.Play();
            pierced++;
            if(pierce ==false)
            { Destroy(gameObject); }
            if (pierced >= 2)
            {
                ScreenShake.shakeDuration = 0.5f;
            }
        }
      
    }
}
