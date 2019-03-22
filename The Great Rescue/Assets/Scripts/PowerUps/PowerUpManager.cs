using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public GameObject PowerUp1;
    public GameObject PowerUp2;
    private GameObject PowerUp1instance;
    private GameObject PowerUp2instance;
    private int pick;
    public static bool powerspawn = false;
    public static Vector3 entitypos;
    public int Pw1LuckCap;
    public int Pw2LuckCap;

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
                if (Random.Range(1, Pw1LuckCap+1) == 1)
                {
                    PowerUp1instance = Instantiate(PowerUp1) as GameObject;
                    PowerUp1instance.transform.position = entitypos;
                    
                }
            }
        }
        if (pick == 2)
        {
            if (Random.Range(1, Pw2LuckCap+1) == 1)
            {
               
                PowerUp2instance = Instantiate(PowerUp2) as GameObject;
                PowerUp2instance.transform.position = entitypos;
            }
        }
    }
}

