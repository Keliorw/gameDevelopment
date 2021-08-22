using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShopScript : MonoBehaviour
{
    public GameObject FirstChestPanel;
    public GameObject SecondChestPanel;

    public void CloseChestPanels()
    {
        FirstChestPanel.SetActive(false);
        SecondChestPanel.SetActive(false);
    }
    void Awake()
    {
        CloseChestPanels();
    }

    public void ActiveFirstChestPanel ()
    {
        FirstChestPanel.SetActive(true);
    }

    public void ActiveSecondChestPanel()
    {
        SecondChestPanel.SetActive(true);
    }

}
