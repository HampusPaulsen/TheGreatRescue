using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrek : MonoBehaviour
{

    private Vector2 position;
    public float speed;
    private float direction;

    public float time = 5f;
    private float timeactual;




    // Start is called before the first frame update
    void Start()
    {
        
        position = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {


        transform.position = Vector2.MoveTowards(transform.position, new Vector2(-100, transform.position.y), speed * Time.deltaTime);
      
    }
    void OnBecameInvisible()
    {

        Destroy(gameObject);
    }

}