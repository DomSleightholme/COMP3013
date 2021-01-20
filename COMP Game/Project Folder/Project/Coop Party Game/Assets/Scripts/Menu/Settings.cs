using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;


public class Settings : MonoBehaviour
{
    public AudioMixer MusicMixer;
    public AudioMixer SFXMixer;

    public Slider MusicSlider;
    public Slider SFXSlider;

    float music;
    float sfx;

    public List<string> options;

    public int currentResolutionIndex = 0;
    private void Start()
    {

        StartMusic();
        StartSFX();

        SFXSlider.value = sfx;
        MusicSlider.value = music;

        options = new List<string>();   
    }

    private float StartMusic()
    {
        bool musicResult = MusicMixer.GetFloat("MusicVolume", out music);

        if (musicResult)
        {
            return music;
        }
        else
        {
            return 0f;
        }
    }
    private float StartSFX()
    {
        bool sfxResult = SFXMixer.GetFloat("SFXVolume", out sfx);
        if (sfxResult)
        {
            return sfx;
        }
        else
        {
            return 0;
        }
    }

    public void SetMusicVolume(float volume)
    {
        MusicMixer.SetFloat("MusicVolume", volume);
    }
    public void SetSFXVolume(float volume)
    {
        SFXMixer.SetFloat("SFXVolume", volume);
    }

    public void Window()
    {
        if(Screen.fullScreen == true)
        {
            Screen.fullScreen = false;
            Debug.Log("Off");
        }
        else
        {
            Screen.fullScreen = true;
            Debug.Log("On");
        }
    }
}
