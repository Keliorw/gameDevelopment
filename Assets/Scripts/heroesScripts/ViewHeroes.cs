using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ViewHeroes : MonoBehaviour
{
    [Header("Объект Окна персонажа")]
    public GameObject Board;

    [Header("Здоровье")]
    public Text Health;
    [Header("Защита")]
    public Text Defence;
    [Header("Мана")]
    public Text Mana;
    [Header("Уровень")]
    public Text Level;
    [Header("Имя героя")]
    public Text NameHeroe;

    private HeroesData loadedListHeroes;
    private MobsData loadedListMobs;

    private bool FlagHeroes = false;

    private string filePath = Application.streamingAssetsPath+"/Heroes.json";

    public void ClickMobs(string Mobs){
        string dataAsJson = File.ReadAllText(filePath);
        loadedListMobs = JsonUtility.FromJson<MobsData>(dataAsJson);
        FlagHeroes = false;
        SetDataText(Mobs);
    }

    public void ClickHeroes(string Heroe){
        string dataAsJson = File.ReadAllText(filePath);
        loadedListHeroes = JsonUtility.FromJson<HeroesData>(dataAsJson);
        FlagHeroes = true;
        SetDataText(Heroe);
    }

    private void SetDataText(string Entity){
        if(FlagHeroes){
            HeroesData loadedList = loadedListHeroes;
            for (int i = 0; i < loadedList.Heroes.Length; i++)
            {
                if(loadedList.Heroes[i].Name == Entity){
                    /*Имя героя*/
                    Text NameText = NameHeroe.GetComponent<Text>();
                    NameText.text = loadedList.Heroes[i].Name;
                    /*Имя героя*/

                    /*Характеристики*/
                    Text HealthText = Health.GetComponent<Text>();//Здоровье
                    HealthText.text = "Здоровье: "+loadedList.Heroes[i].Health;
                    Text DefenceText = Defence.GetComponent<Text>();//Защита
                    DefenceText.text = "Защита: "+loadedList.Heroes[i].Defence;
                    Text ManaText = Mana.GetComponent<Text>();//Мана
                    ManaText.text = "Мана: "+loadedList.Heroes[i].Mana;
                    /*Характеристики*/

                    /*Уровень героя*/
                    Text LevelText = Level.GetComponent<Text>();
                    LevelText.text = "Lv. "+loadedList.Heroes[i].Level;
                    /*Уровень героя*/
                }
            }
        } else {
            MobsData loadedList = loadedListMobs;
            for (int i = 0; i < loadedList.Mobs.Length; i++)
            {
                if(loadedList.Mobs[i].Name == Entity){
                    /*Имя Моба*/
                    Text NameText = NameHeroe.GetComponent<Text>();
                    NameText.text = loadedList.Mobs[i].Name;
                    /*Имя Моба*/

                    /*Характеристики*/
                    Text HealthText = Health.GetComponent<Text>();//Здоровье
                    HealthText.text = "Здоровье: "+loadedList.Mobs[i].Health;
                    Text DefenceText = Defence.GetComponent<Text>();//Защита
                    DefenceText.text = "Защита: "+loadedList.Mobs[i].Defence;
                    Text ManaText = Mana.GetComponent<Text>();//Мана
                    ManaText.text = "Мана: "+loadedList.Mobs[i].Mana;
                    /*Характеристики*/

                    /*Уровень Моба*/
                    Text LevelText = Level.GetComponent<Text>();
                    LevelText.text = "Lv. "+loadedList.Mobs[i].Level;
                    /*Уровень Моба*/
                }
            }
        }
        Board.SetActive(true);
    }

    public void CloseBoard(){
        Board.SetActive(false);
    }
}
