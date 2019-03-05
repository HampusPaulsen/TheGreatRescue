using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyCount : MonoBehaviour
{
    [SerializeField]
    public int G1;
    [SerializeField]
    public int O1;
    [SerializeField]
    public int T1;
    [SerializeField]
    public int G2;
    [SerializeField]
    public int O2;
    [SerializeField]
    public int T2;
    [SerializeField]
    public int G3;
    [SerializeField]
    public int O3;
    [SerializeField]
    public int T3;
    [SerializeField]
    public int G4;
    [SerializeField]
    public int O4;
    [SerializeField]
    public int T4;
    [SerializeField]
    public int G5;
    [SerializeField]
    public int O5;
    [SerializeField]
    public int T5;
    [SerializeField]
    public static int Goblin = 0;
    public static int Orc = 0;
    public static int Troll = 0;
    [SerializeField]
    public GameObject Wave1;
    [SerializeField]
    public GameObject Wave2;
    [SerializeField]
    public GameObject Wave3;
    [SerializeField]
    public GameObject Wave4;
    [SerializeField]
    public GameObject Wave5;

    bool W1 = true;
    bool W2 = false;
    bool W3 = false;
    bool W4 = false;
    bool W5 = false;
   
   
    // Start is called before the first frame update
    void Start()
    {
        G2 += G1;
        O2 += O1;
        T2 += T1;
        G3 += G2;
        O3 += O2;
        T3 += T2;
        G4 += G3;
        O4 += O3;
        T4 += T3;
        G5 += G4;
        O5 += O4;
        T5 += T4;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (W1 == true)
        {
            if (BgScroll.MoveBg == false)
                Wave1.SetActive(true);
            Wave1Check();


        }
        if (W2 == true)
        {
            if (BgScroll.MoveBg == false)
            { Wave2.SetActive(true); }
            Wave2Check();

        }
        if (W3 == true)
        {
            if (BgScroll.MoveBg == false)
            { Wave3.SetActive(true); }
            Wave3Check();

        }
        if (W4 == true)
        {
            if (BgScroll.MoveBg == false)
            { Wave4.SetActive(true); }
            Wave4Check();

        }
        if (W5 == true)
        {
            if (BgScroll.MoveBg == false)
            { Wave5.SetActive(true); }
           

        }



    }
    void WaveCheck()
    {
   
    }




    void Wave1Check()
    {
      if (G1 == Goblin && O1 == Orc && T1 == Troll)
      { 
            if (BgScroll.MoveBg == false)
            {

                BgScroll.MoveBg = true;
                    W2 = true;
                    Wave1.SetActive(false);
                    W1 = false;
                
            }
                
      }
    }
    void Wave2Check()
    {
        if (G2 == Goblin && O2 == Orc && T2 == Troll)
        { 
            if (BgScroll.MoveBg == false)
            {
                BgScroll.MoveBg = true;
                W3 = true;
                Wave2.SetActive(false);
                W2 = false;
            }
        }
    }
    void Wave3Check()
    {
        if (G3 == Goblin && O3 == Orc && T3 == Troll)
        { 
            if (BgScroll.MoveBg == false)
            {
                W4 = true;
                Wave3.SetActive(false);
               
                BgScroll.MoveBg = true;
                W3 = false;
            }
        }
    }
    void Wave4Check()
    {
        if (G4 == Goblin && O4 == Orc && T4 == Troll)
        { 
            if (BgScroll.MoveBg == false)
            {
                W5 = true;
                BgScroll.MoveBg = true;
                Wave4.SetActive(false);
                
                W4 = false;
            }
        }

    }

}
