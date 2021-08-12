using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenChestScript : MonoBehaviour
{
    private int chestDroppedMoney;
    private int chestDroppedExp;
    private int chestDroppedHeroes;
    public Text chestDroppedMoneyText;
    public Text chestDroppedExpText;
    public GameObject chestDroppedHero;
    public void OpenChest()
    {
        chestDroppedMoney = Random.Range(1000, 5000);
        chestDroppedExp = Random.Range(1000, 5000);
        Debug.Log("Dropped money = " + chestDroppedMoney);
        Debug.Log("Dropped exp = " + chestDroppedExp);
    }
}
