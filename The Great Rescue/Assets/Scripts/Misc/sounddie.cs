using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sounddie : MonoBehaviour
{
    public AudioSource efxSource;
    public float time = 2.0f;
    public float lowPitchRange = .95f;              //The lowest a sound effect will be randomly pitched.
    public float highPitchRange = 1.05f;            //The highest a sound effect will be randomly pitched.

    // Start is called before the first frame update
    void Start()
    {
        float randomPitch = Random.Range(lowPitchRange, highPitchRange);
        efxSource.pitch = randomPitch;
        efxSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;

        if (time <= 0.0f)
        {
            Destroy(gameObject);
        }
    }
   
}
