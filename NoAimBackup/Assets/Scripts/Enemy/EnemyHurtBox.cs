using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHurtBox : MonoBehaviour
{
    public GameObject hurtbox;
    public float time= 5.0f;
    private float timeactual;
   
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        timeactual -= Time.deltaTime;
     
        if(timeactual <= 0.0f)
        {
            GameObject hurtboxob = (GameObject)Instantiate(hurtbox);
            hurtboxob.transform.position = gameObject.transform.position;
            timeactual = time;
        }
     
    }
}
  
