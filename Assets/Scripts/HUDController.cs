using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour

{
    public PlayerItems playerItems;
    public Text riceCount;
    public Text slimeCount;
    public Text rissotoCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateCount();
    }

    void UpdateCount()
    {
        riceCount.text = playerItems.getTotalRice().ToString();
        slimeCount.text = playerItems.getTotalSlime().ToString();
        rissotoCount.text = playerItems.getTotalRisottoSlime().ToString();
    }
}
