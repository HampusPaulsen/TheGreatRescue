using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{ 
    private int health;
    public float time = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    health = PlayerScript.health;

        if (health == 0)
        {
            time -= Time.deltaTime;

            if (time <= 0.0f)
            {

                UnityEngine.SceneManagement.SceneManager.LoadScene("5. DeathScene");
            }

        }

        
    }
}
