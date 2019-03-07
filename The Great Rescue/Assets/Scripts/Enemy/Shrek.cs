using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrek : MonoBehaviour
{

    private Vector2 position;
    public float speed;
    private float direction;

    public float time = 5f;
    private float timeelapsed=0;
    AudioSource m_MyAudioSource;




    // Start is called before the first frame update
    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
        m_MyAudioSource.Play();
        position = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("PlayerCharacter") == null)
        {



            Destroy(gameObject);
        }
        if (BgScroll.MoveBg == true)
        { Destroy(gameObject); }


        transform.position = Vector2.MoveTowards(transform.position, new Vector2(-200, transform.position.y), speed * Time.deltaTime);
        timeelapsed += Time.deltaTime;
        if(timeelapsed >= time)
        {
            Destroy(gameObject);
        }
    }

}