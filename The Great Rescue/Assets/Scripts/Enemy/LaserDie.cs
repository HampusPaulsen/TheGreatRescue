using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserDie : MonoBehaviour
{
    public float time = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (BgScroll.MoveBg == true)
        {
            Destroy(gameObject);
        }

        if (GameObject.Find("PlayerCharacter") == null)
        {



            Destroy(gameObject);
        }
        time -= Time.deltaTime;

        if (time <= 0.0f)
        {
            Destroy(gameObject);
        }

    }
}
