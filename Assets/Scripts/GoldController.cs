using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class GoldController : MonoBehaviour

{

    public PlayerItems playerItems;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SellingRisottoSlime();
        }
    }


    private void SellingRisottoSlime()

    {

        int goldCount = playerItems.getTotalGold();

        int risottoCount = playerItems.getTotalRisottoSlime();


        if (risottoCount > 0)

        {

            playerItems.setTotalRisottoSlime(risottoCount - 1);

            playerItems.setTotalGold(goldCount + 2);


        }


        else

        {

            Debug.Log("Não vendeu");

        }

    }

}
