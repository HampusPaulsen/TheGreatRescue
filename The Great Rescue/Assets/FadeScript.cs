using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class FadeScript : MonoBehaviour
{
    float blinkDurationSecs = 0.5f;
    float blinkProgress = 0f;
    public float blinkStep = 0.01f;
    //Color txtColor = Color.black;
    public TextMeshProUGUI textmeshPro;
    // Use this for initialization
    void Start()
    {
        TextMeshProUGUI textmeshPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((blinkProgress > 1) || (blinkProgress < 0))
        {
            blinkStep *= -1f;
        }
        blinkProgress += blinkStep;
        textmeshPro.color = Color.Lerp(Color.black, Color.white, blinkProgress);// or whatever color you choose
    }
}