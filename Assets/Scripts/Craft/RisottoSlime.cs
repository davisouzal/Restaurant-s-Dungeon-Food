using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RisottoSlime : MonoBehaviour
{
    public PlayerItems playerItems;

    public void OnMouseDown()
    {
        CraftRisottoSlime();
    }

    private void CraftRisottoSlime()
    {
        int riceCount = playerItems.getTotalRice(); // Removed 'private'
        int slimeCount = playerItems.getTotalSlime(); // Corrected the method call
        int risottoCount = playerItems.getTotalRisottoSlime();

        // You might want to check if the player has enough resources
        if (riceCount > 0 && slimeCount > 0)
        {
            playerItems.setTotalRice(riceCount - 1); // Deduct one unit of rice
            playerItems.setTotalSlime(slimeCount - 1); // Deduct one unit of slime
            playerItems.setTotalRisottoSlime(risottoCount + 1); // Increase risotto slime
        }

        else
        {
            Debug.Log("Não foi");
        }
    }
}
