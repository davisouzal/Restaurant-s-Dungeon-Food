using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RisottoSlime : MonoBehaviour
{
    public PlayerItems playerItems;
    public AudioSource audiocraft;

    public void OnMouseDown()
    {
        CraftRisottoSlime();
    }
 
    private void CraftRisottoSlime()
    {
        int riceCount = playerItems.getTotalRice();
        int slimeCount = playerItems.getTotalSlime(); 
        int risottoCount = playerItems.getTotalRisottoSlime();

        if (riceCount > 0 && slimeCount > 0)
        {
            playerItems.setTotalRice(riceCount - 1); 
            playerItems.setTotalSlime(slimeCount - 1);
            playerItems.setTotalRisottoSlime(risottoCount + 1);
            audiocraft.Play();
        }

        else
        {
            Debug.Log("Não foi");
        }
    }
}
