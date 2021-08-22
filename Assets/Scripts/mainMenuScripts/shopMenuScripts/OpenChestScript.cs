using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenChestScript : MonoBehaviour
{
    private int chestDroppedMoney;
    private int chestDroppedBooks;
    private int chestDroppedHeroes;

    private int[] defaltChestDroppedMoney = { 100, 500 };
    private int[] defaltChestDroppedBooks = { 1, 14 };

    private int[] rareChestDroppedMoney = { 1000, 5000 };
    private int[] rareChestDroppedBooks = { 14, 30 };

    private int heroDropDefaltChanse = 15;
    private int heroDropRareChanse = 90;

    public GameObject ObjectPlayerHeroes;
    private Heroes hero;

    private void Awake()
    {
        hero = ObjectPlayerHeroes.GetComponent<Heroes>();
    }

    public Text chestDroppedMoneyText;
    public Text chestDroppedExpText;
    public GameObject chestDroppedHero;
    public void OpenDefaultChest()
    {
        DroppedCurrency(1);
        if(hero.HeroesLvLCheck())
        {
            DroppedHeroes(1);
        }
    }

    public void OpenRareChest()
    {
        DroppedCurrency(2);
        if (hero.HeroesLvLCheck())
        {
            DroppedHeroes(2);
        }
    }
    private void DroppedCurrency(int chest)
    {
        int parity = Random.Range(1, 3);
        switch (chest)
        {
            case 1:
                if (parity == 1)
                {
                    chestDroppedMoney = Random.Range(defaltChestDroppedMoney[0], defaltChestDroppedMoney[1]/2);
                    chestDroppedBooks = Random.Range(defaltChestDroppedBooks[1]/2, defaltChestDroppedBooks[1]);
                }
                if (parity == 2)
                {
                    chestDroppedMoney = Random.Range(defaltChestDroppedMoney[1]/2, defaltChestDroppedMoney[1]);
                    chestDroppedBooks = Random.Range(defaltChestDroppedBooks[0], defaltChestDroppedBooks[1]/2);
                }
                break;
            case 2:
                if (parity == 1)
                {
                    chestDroppedMoney = Random.Range(rareChestDroppedMoney[0], rareChestDroppedMoney[1]/2);
                    chestDroppedBooks = Random.Range(rareChestDroppedBooks[1]/2, rareChestDroppedBooks[1]);
                }
                if (parity == 2)
                {
                    chestDroppedMoney = Random.Range(rareChestDroppedMoney[1]/2, rareChestDroppedMoney[1]);
                    chestDroppedBooks = Random.Range(rareChestDroppedBooks[0], rareChestDroppedBooks[1]/2);
                }
                break;
        }
        Debug.Log("Money: " + chestDroppedMoney);
        Debug.Log("Books: " + chestDroppedBooks);
    }

    private void DroppedHeroes(int chest)
    {
        int heroChanse = Random.Range(0, 100);
        switch (chest)
        {
            case 1:
                if (heroChanse < heroDropDefaltChanse)
                {
                    while (true)
                    {
                        int newHero = Random.Range(0, 10);
                        if ((hero.GetHero(newHero) + 1) <= hero.GetmaxLvL())
                        {
                            hero.SetHero(newHero);
                            Debug.Log("You achive " + (newHero + 1) + " hero, he is " + hero.GetHero(newHero) + " level! ");
                            break;
                        }
                    }
                }
                break;
            case 2:
                if (heroChanse < heroDropRareChanse)
                {
                    while (true)
                    {
                        int newHero = Random.Range(0, 10);
                        if ((hero.GetHero(newHero) + 1) <= hero.GetmaxLvL())
                        {
                            hero.SetHero(newHero);
                            Debug.Log("You achive " + (newHero + 1) + " hero, he is " + hero.GetHero(newHero) + " level! ");
                            break;
                        }
                    } 
                }
                break;
        }
    }
}
