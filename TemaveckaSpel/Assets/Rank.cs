using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rank : MonoBehaviour
{
   // int Rng = new Random();
    public int TRanking = 1;
    public int FRanking = 0;
    public int ARanking = 3 /*Rng.next(1, 5)*/;
    public bool FRMaking = true;
    public bool Alive = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            if(TRanking < 5)
            {
                TRanking = TRanking++;
            }
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            if(TRanking > 1) 
            {
                TRanking = TRanking--;
            }
        }
        if(FRMaking = true && Input.GetKeyDown(KeyCode.E))
        {
            FRMaking = false;
            FRanking = TRanking;
            if(FRanking == ARanking)
            {

            }
            else
            {
                Alive = false;
            }
        }
        // 1 - Harmless
        // 2 - relative harmless
        // 3 - dangerous
        // 4 - letal
        // 5 - extremely letal
    }
}
