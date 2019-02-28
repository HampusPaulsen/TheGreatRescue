using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHurtBox : MonoBehaviour
{
    
    public Collider2D m_Collider;
    float time;
    public float firerate;
    // Start is called before the first frame update
    void Start()
    {
        m_Collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /*  time += Time.deltaTime;
          if (time >= firerate)
          {

              if (time >= firerate / 2)
              {
                  m_Collider.enabled = true;
              }
              time = 0;
              m_Collider.enabled = false;

          }*/
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name=="PlayerCharacter")
        {
            PlayerScript.health--;
        }
    }
}
