using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    private AudioSource audioScr;
    private AudioClip[] audioClips;
    private float musicVolume = 1f;
    public Sprite MusicOn;
    public Sprite MusicOff;
    private int numberOfCurrendMusic;
    void Start()
    {
        numberOfCurrendMusic = 0;
        audioScr = GetComponent<AudioSource>();
        audioClips = Resources.LoadAll<AudioClip>("MainMenuMusic");
        audioScr.PlayOneShot(audioClips[numberOfCurrendMusic]);
    }

    private void Update()
    {
        audioScr.volume = musicVolume;
        if (!audioScr.isPlaying)
        {
            audioScr.PlayOneShot(audioClips[numberOfCurrendMusic]);
            numberOfCurrendMusic++;
            if (numberOfCurrendMusic > audioClips.Length - 1)
            {
                numberOfCurrendMusic = 0;
            }
        }
        
    }

    public void SwitchMusicVolume ()
    {
        if (musicVolume == 1f)
        {
            musicVolume = 0f;
            GameObject SettingsPanel = GameObject.Find("SwitchMusicButton");
            Image bg = SettingsPanel.GetComponent<Image>();
            bg.sprite = MusicOff;
        }
        else
        {
            musicVolume = 1f;
            GameObject SettingsPanel = GameObject.Find("SwitchMusicButton");
            Image bg = SettingsPanel.GetComponent<Image>();
            bg.sprite = MusicOn;
        }
    }
}
