using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeftHudController : MonoBehaviour
{
    public PlayerItems playerItems;
    public Text goldCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateGold();  
    }   

    void UpdateGold()
    {
        goldCount.text = playerItems.getTotalGold().ToString();
    }
}
