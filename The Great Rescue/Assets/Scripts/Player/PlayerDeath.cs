using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    AudioSource m_MyAudioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("PlayerCharacter") != null)
        {
            
            m_MyAudioSource.Play();
            
        }




    }
}
