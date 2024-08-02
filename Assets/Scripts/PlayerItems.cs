using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItems : MonoBehaviour
{
    public int totalRise = 2;
    public int totalSlime = 1 ;
    public int totalRisottoSlime = 1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getTotalRice()
    {
        return totalRise;
    }

    public int getTotalSlime()
    {
        return totalSlime;
    }

    public int getTotalRisottoSlime()
    {
        return totalRisottoSlime;
    }
}
