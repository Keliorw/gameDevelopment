using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class LocalizationManager : MonoBehaviour
{
    public static LocalizationManager instance;
    public GameObject ObjectSavePlayer;

    private SavePlayer saver;
    private Dictionary<string, string> localizedText;
    private bool isReady = false;
    private string missingTextString = "Localized text not found";

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        
        saver = ObjectSavePlayer.GetComponent<SavePlayer>();
        if (saver.asd() == 1)
        {
            saver.SetLanguage("ru_RU.json");
        }
        Debug.Log(saver.GetLanguage());
        LoadLocalizedText(saver.GetLanguage());
    }

    public void OnButtonClicked (string fileName)
    {
        LoadLocalizedText(fileName, true);
    }
    public void LoadLocalizedText(string fileName, bool flag = false)
    {
        localizedText = new Dictionary<string, string>();
        string filePath = Path.Combine(Application.streamingAssetsPath, fileName);

        if (File.Exists(filePath))
        {
            string dataAsJson = File.ReadAllText(filePath);
            LocalizationData loadedData = JsonUtility.FromJson<LocalizationData>(dataAsJson);

            for (int i = 0; i < loadedData.items.Length; i++)
            {
                localizedText.Add(loadedData.items[i].key, loadedData.items[i].value);
            }

            if (flag)
            {
                saver.SetLanguage(fileName);
                SceneManager.LoadScene(0);
            }
            Debug.Log("Data loaded, dictionary contains: " + localizedText.Count + " entries");
        }
        else
        {
            Debug.LogError("Cannot find file!");
        }

        isReady = true;
    }

    public string GetLocalizedValue(string key)
    {
        string result = missingTextString;
        if (localizedText.ContainsKey(key))
        {
            result = localizedText[key];
        }

        return result;

    }

}