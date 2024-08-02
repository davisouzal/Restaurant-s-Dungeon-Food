using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItems : MonoBehaviour
{
    public int totalRise;
    public int totalSlime;
    public int totalRisottoSlime;
    public int totalGold;


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

    public int getTotalGold()
    {
        return totalGold;
    }
    public void setTotalGold(int totalGold)
    {
        this.totalGold = totalGold;
    }

}
