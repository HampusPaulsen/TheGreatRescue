using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public GameObject PowerUp1;
    public GameObject PowerUp2;
    private int pick;
    public static bool powerspawn = false;
    public static Vector3 entitypos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (powerspawn == true)
        {
            SpawnPowerUp(entitypos);
        }
    }
    void SpawnPowerUp(Vector3 entitypos)
    {
        powerspawn = false;

        pick = Random.Range(1, 3);
        if (pick == 1)
        {
            if (PlayerScript.health < 5)
            {
                if (Random.Range(1, 3) == 2)
                {
                    PowerUp1 = Instantiate(PowerUp1) as GameObject;
                    PowerUp1.transform.position = entitypos;
                    
                }
            }
        }
        if (pick == 2)
        {
            if (Random.Range(1, 3) == 2)
            {
               
                PowerUp2 = Instantiate(PowerUp2) as GameObject;
                PowerUp2.transform.position = entitypos;
            }
        }
    }
}

