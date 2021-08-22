using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heroes : MonoBehaviour
{
    public static int heroCount = 10;
    private static int maxLvL = 5;
    public int[] heroes = new int [heroCount];

    public void SetHero (int hero)
    {
        heroes[hero]++;
    }
    
    public int GetHero (int hero)
    {
        return heroes[hero];
    }

    public int GetmaxLvL()
    {
        return maxLvL;
    }

    public bool HeroesLvLCheck ()
    {
        int heroesMaxLvLcount = 0;
        for (int i = 0; i < heroCount; i++)
        {
            if (heroes[i] == maxLvL) heroesMaxLvLcount++;
        }
        if (heroesMaxLvLcount == heroCount)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
