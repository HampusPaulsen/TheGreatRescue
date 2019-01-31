using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedEnemy1 : MonoBehaviour
{

    private Transform target;
    private Transform enemyPosition;
    public float speed;
    private float direction;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Target").GetComponent<Transform>();
        enemyPosition = GameObject.FindGameObjectWithTag("RangedEnemy1").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        

      
    }
} 
