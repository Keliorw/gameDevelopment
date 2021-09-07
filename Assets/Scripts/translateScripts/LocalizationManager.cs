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
        
        saver = ObjectSavePlayer.GetComponent<SavePlayer>();
        LoadLocalizedText();
    }

    private void Start(){
        
    }

    private void LoadLocalizedText()
    {
        localizedText = new Dictionary<string, string>();
        LanguageData languageInSave = JsonUtility.FromJson<LanguageData>(File.ReadAllText(Application.streamingAssetsPath+"/Save.json"));
        Debug.Log(languageInSave);
        string filePath = Path.Combine(Application.streamingAssetsPath, languageInSave.language);
        
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
        Debug.Log(fileName);
        saver.SetLanguage(fileName);
        SceneManager.LoadScene(0);
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