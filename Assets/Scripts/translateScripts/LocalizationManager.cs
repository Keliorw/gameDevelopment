using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class LocalizationManager : MonoBehaviour
{
    public static LocalizationManager instance;

    private LanguageData languageInSave;
    private Dictionary<string, string> localizedText;
    private string missingTextString = "Localized text not found";

    private void Awake()
    {
        
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        // DontDestroyOnLoad(gameObject);

        languageInSave = JsonUtility.FromJson<LanguageData>(File.ReadAllText(Application.streamingAssetsPath + "/Save.json"));
        LoadLocalizedText();
    }

    private void LoadLocalizedText()
    {
        localizedText = new Dictionary<string, string>();
        
        string filePath = Path.Combine(Application.streamingAssetsPath, languageInSave.language + ".json");

        if (File.Exists(filePath))
        {
            string dataAsJson = File.ReadAllText(filePath);
            LocalizationData loadedData = JsonUtility.FromJson<LocalizationData>(dataAsJson);

            for (int i = 0; i < loadedData.items.Length; i++)
            {
                localizedText.Add(loadedData.items[i].key, loadedData.items[i].value);
            }
            Debug.Log("Data loaded, dictionary contains: " + localizedText.Count + " entries");
        }
        else
        {
            Debug.LogError("Cannot find file!");
        }
    }

    public void LocalizeText (string fileName)
    {
        languageInSave.language = fileName;
        string filePath = Path.Combine(Application.streamingAssetsPath, "Save.json");
        if (File.Exists(filePath))
        {
            File.WriteAllText(filePath, JsonUtility.ToJson(languageInSave));
            SceneManager.LoadScene(0);
        }
        else
        {
            Debug.LogError("Cannot find file!");
        }
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