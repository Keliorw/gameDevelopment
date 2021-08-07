using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocalizedText : MonoBehaviour
{
    public string key;
    void Start()
    {
        Text Line = GetComponent<Text>();
        Line.text = LocalizationManager.instance.GetLocalizedValue(key);
        Debug.Log(LocalizationManager.instance.GetLocalizedValue(key));
    }

}
