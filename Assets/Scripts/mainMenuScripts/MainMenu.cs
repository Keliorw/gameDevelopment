using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject playMenuPanel;
    public GameObject settingsMenuPanel;
    public GameObject upgradeMenuPanel;
    public GameObject shopMenuPanel;
    public GameObject heroesListPanel;
    public GameObject mobsListPanel;
    public GameObject infoLvLPanel;


    private void Awake()
    {
        mainMenuPanel.SetActive(true);
        playMenuPanel.SetActive(false);
        settingsMenuPanel.SetActive(false);
        upgradeMenuPanel.SetActive(false);
        shopMenuPanel.SetActive(false);
        heroesListPanel.SetActive(true);
        mobsListPanel.SetActive(false);
    }
    public void PanelMainMenu()
    {
        mainMenuPanel.SetActive(true);
        playMenuPanel.SetActive(false);
        settingsMenuPanel.SetActive(false);
        upgradeMenuPanel.SetActive(false);
        shopMenuPanel.SetActive(false);
    }
    public void PlayMenu()
    {
        mainMenuPanel.SetActive(false);
        playMenuPanel.SetActive(true);
        settingsMenuPanel.SetActive(false);
        upgradeMenuPanel.SetActive(false);
        shopMenuPanel.SetActive(false);
    }

    public void SettingsMenu()
    {
        if(settingsMenuPanel.activeSelf)
        {
            settingsMenuPanel.SetActive(false);
        } else
        {
            settingsMenuPanel.SetActive(true);
        }
    }

    public void UpgradeMenu()
    {
        if (upgradeMenuPanel.activeSelf)
        {
            upgradeMenuPanel.SetActive(false);
        }
        else
        {
            upgradeMenuPanel.SetActive(true);
        } 
    }

    public void ShopMenu()
    {
        if (shopMenuPanel.activeSelf)
        {
            shopMenuPanel.SetActive(false);
        }
        else
        {
            shopMenuPanel.SetActive(true);
        }
    }


    public void ShowInfoLvLPanel()
    {
        if (infoLvLPanel.activeSelf)
        {
            infoLvLPanel.SetActive(false);
        }
        else
        {
            infoLvLPanel.SetActive(true);
        }
    }

    public void ShowHeroesRepositoryPanel()
    {
        heroesListPanel.SetActive(true);
        mobsListPanel.SetActive(false);
    }

    public void ShowMobsRepositoryPanel ()
    {
        mobsListPanel.SetActive(true);
        heroesListPanel.SetActive(false);
    }

}

