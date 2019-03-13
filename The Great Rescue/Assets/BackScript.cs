using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadStartScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("0. StartScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
