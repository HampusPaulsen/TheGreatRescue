using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGameScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadMainScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("3. MainScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
