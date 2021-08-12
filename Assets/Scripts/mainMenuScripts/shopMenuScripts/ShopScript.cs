using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShopScript : MonoBehaviour
{
    public GameObject BuyInfoPanel;

    public void CloseBuyInfoPanel()
    {
        BuyInfoPanel.SetActive(false);
    }
    void Awake()
    {
        CloseBuyInfoPanel();
    }

    public void ActiveBuyInfoPanel ()
    {
        BuyInfoPanel.SetActive(true);
    }
    
}
