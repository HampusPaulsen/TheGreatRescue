using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadInstructionScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("1. HowToPlayScene");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
