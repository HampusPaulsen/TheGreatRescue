using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBox : MonoBehaviour
{
    public GameObject hurtbox;
    public float time = 5.0f;
    private float timeactual;

    // Start is called before the first frame update
    void Start()
    {
        timeactual = time;
    }

    // Update is called once per frame
    void Update()
    {
        timeactual -= Time.deltaTime;

        if (timeactual <= 0.0f)
        {
            
        
            var hurtboxob = (GameObject)Instantiate(hurtbox);
            hurtboxob.transform.position = gameObject.transform.position;
            hurtboxob.transform.parent = gameObject.transform;

            timeactual = time;
        }

    }
}
