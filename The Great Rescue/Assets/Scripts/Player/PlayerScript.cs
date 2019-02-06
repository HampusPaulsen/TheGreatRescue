using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    private float speed = 3.0f; //Change this to change the speed of the player character

    private Vector2 direction;

    void Start() //Empty, for now
    {
    }

    void Update() //Calls functions once per frame
    {
        GetInput();
        PlayerMovement();
    }

    private void GetInput()
    {
        direction = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector2.up;
        }

        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;
        }

        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector2.down;
        }

        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector2.right;
        }
    }

    public void PlayerMovement() 
    {
        //This will move the player according to their direction * speed * time in seconds
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
