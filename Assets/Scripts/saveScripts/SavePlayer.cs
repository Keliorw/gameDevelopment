using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class SavePlayer : MonoBehaviour
{
    public static SavePlayer instanceSavePlayer;
    private Save sv = new Save();
    private string path;

    private void Start()
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        path = Path.Combine(Application.persistentDataPath, "Save.json");
#else
        path = Path.Combine(Application.dataPath, "Save.json");
#endif
        if (File.Exists(path))
        {
            sv = JsonUtility.FromJson<Save>(File.ReadAllText(path));
            Debug.Log("Language: " + sv.language);
        }
        else Debug.Log("Language: " + sv.language);
    }

    public void SetLanguage(string lang)
    {
        sv.language = lang;
    }

    public string GetLanguage()
    {
        return sv.language;
    }

#if UNITY_ANDROID && !UNITY_EDITOR
    private void OnApplicationPause(bool pause)
    {
        if (pause) File.WriteAllText(path, JsonUtility.ToJson(sv));
    }
#endif
    private void OnApplicationQuit()
    {
        File.WriteAllText(path, JsonUtility.ToJson(sv));
    }
}
[Serializable]
public class Save
{
    public string language;
}
