using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class SavePlayer : MonoBehaviour
{
    /*
    private Save sv = new Save();
    private string path;

    private void Awake()
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        path = Path.Combine(Application.streamingAssetsPath, "/Save.json");
#else
        path = Path.Combine(Application.streamingAssetsPath, "/Save.json");
#endif
        if (File.Exists(path))
        {
            sv = JsonUtility.FromJson<Save>(File.ReadAllText(path));
        }
        else Debug.Log("Error");
    }

    public void SetHeroes(int[] saveHeroes, int countHeroes)
    {
        for(int i = 0; i < countHeroes; i++)
        {
            sv.heroes[i] = saveHeroes[i];
        }
    }

#if UNITY_ANDROID && !UNITY_EDITOR
    private void OnApplicationPause(bool pause)
    {
        if (pause) File.WriteAllText(path, JsonUtility.ToJson(sv));
    }
#endif
    private void OnApplicationQuit()
    {
        //File.WriteAllText(path, JsonUtility.ToJson(sv));
    }
    */
}

