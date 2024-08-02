using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItems : MonoBehaviour
{
    public int totalRise;
    public int totalSlime;
    public int totalRisottoSlime;

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

}
