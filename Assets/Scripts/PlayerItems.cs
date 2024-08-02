using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItems : MonoBehaviour
{
    public int totalRise;
    public int totalSlime;
    public int totalRisottoSlime;
    public int totalGold;

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

    public void setTotalRice(int totalRise)
    {
        this.totalRise = totalRise;
    }

    public void setTotalSlime(int totalSlime)
    {
        this.totalSlime = totalSlime;
    }

    public void setTotalRisottoSlime(int totalRisottoSlime)
    {
        this.totalRisottoSlime = totalRisottoSlime;
    }

    public void setTotalGold(int totalGold)
    {
        this.totalGold = totalGold;
    }

}
