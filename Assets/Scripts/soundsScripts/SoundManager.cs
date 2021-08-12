using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoundManager : MonoBehaviour
{
    private AudioSource audioScr;
    private AudioClip[] audioClips;
    private float soundVolume = 1f;
    public Sprite SoundOn;
    public Sprite SoundOff;

    void Start()
    {
        audioScr = GetComponent<AudioSource>();
    }
    private void Update()
    {
        audioScr.volume = soundVolume;
    }

    public void ButtonClicked ()
    {
        audioClips = Resources.LoadAll<AudioClip>("MainMenuSound");
        audioScr.PlayOneShot(audioClips[1]);
    }

    public void SwitchSoundVolume()
    {
        if (soundVolume == 1f)
        {
            soundVolume = 0f;
            GameObject SettingsPanel = GameObject.Find("SwitchSoundButton");
            Image bg = SettingsPanel.GetComponent<Image>();
            bg.sprite = SoundOff;

        }
        else
        {
            soundVolume = 1f;
            GameObject SettingsPanel = GameObject.Find("SwitchSoundButton");
            Image bg = SettingsPanel.GetComponent<Image>();
            bg.sprite = SoundOn;
        }
    }
}
