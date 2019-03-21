using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgScrollPara : MonoBehaviour
{
    public float scrollSpeed = 10f;


    private Vector3 orgpos1;


    private Vector3 targpos1;

 

    public GameObject BG1;

    public static bool MoveBgPara;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 orgpos1 = BG1.transform.position;
 
        targpos1.x = -180;
    
        MoveBgPara = false;
  

        
    }

    // Update is called once per frame
    void Update()
    {
        if (MoveBgPara == true)
        {
            BG1.transform.position = Vector2.MoveTowards(BG1.transform.position, targpos1, scrollSpeed * Time.deltaTime);
            Vector3 checkpos1 = BG1.transform.position;
        
            if (checkpos1.x == -180)
            {
               
           
                
                BG1.transform.position = orgpos1;
             
                
            }
        }
    }
}
