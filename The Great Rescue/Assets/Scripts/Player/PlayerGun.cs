using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    // [SerializeField]
    //private float firerate = 0.0f; //Change to change firerate
    AudioSource m_MyAudioSource;
    public float lowPitchRange = .95f;              //The lowest a sound effect will be randomly pitched.
    public float highPitchRange = 1.05f;            //The highest a sound effect will be randomly pitched.

    [SerializeField]
    private LayerMask whatToHit; //Remember to include layers that should be able to be hit

    [SerializeField]
    private Transform BulletPrefab;

    Transform firePoint;

    float fireTimer = 0;
    float time;
    public float firerate;

    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
    }


    void Awake()
    {
        //Remember to add an empty child to the gun called "FirePoint"
        firePoint = transform.Find("FirePoint");
    }

    void Update()
    {
        if (BgScroll.MoveBg == false)
        {
            /* if (firerate == 0)
             {
                 if (Input.GetKeyUp(KeyCode.Space))
                 {
                     Shoot();
                 }
                 else



                 {
                     if (Input.GetKeyUp(KeyCode.Space) && Time.time > fireTimer)
                     {
                         fireTimer = Time.time + 1 / firerate;
                         Shoot();
                     }
                 }
             }*/
            time += Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space) && time >= firerate)
            {
                time = 0;
                float randomPitch = Random.Range(lowPitchRange, highPitchRange);
                m_MyAudioSource.pitch = randomPitch;
                m_MyAudioSource.Play();
                
                Shoot();
            }

            if (Input.GetKeyDown(KeyCode.Mouse0) && time >= firerate)
            {
                time = 0;
                float randomPitch = Random.Range(lowPitchRange, highPitchRange);
                m_MyAudioSource.pitch = randomPitch;
                m_MyAudioSource.Play();
                Shoot();
            }

            if (Input.GetKeyDown(KeyCode.Mouse1) && time >= firerate)
            {
                time = 0;
                float randomPitch = Random.Range(lowPitchRange, highPitchRange);
                m_MyAudioSource.pitch = randomPitch;
                m_MyAudioSource.Play();
                Shoot();
            }
        }
        //Raycasting
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        if (rotZ > -30 && rotZ < 30)
        {
            transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotZ);
        }
    }

    void Shoot()
    {
        //Raycasting
        Vector2 mousePosition = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        Vector2 firePointPosition = new Vector2(firePoint.position.x, firePoint.position.y);
        RaycastHit2D hit = Physics2D.Raycast(firePointPosition, mousePosition - firePointPosition, 100, whatToHit);

        Effect();
    }

    void Effect()
    {
        Instantiate(BulletPrefab, firePoint.position, firePoint.rotation);
    }
}
