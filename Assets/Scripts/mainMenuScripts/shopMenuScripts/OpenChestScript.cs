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
        chestDroppedMoney = Random.Range(10, 50);
        chestDroppedExp = Random.Range(5, 10);
        Debug.Log("Dropped money = " + chestDroppedMoney);
        Debug.Log("Dropped exp = " + chestDroppedExp);
    }
}
