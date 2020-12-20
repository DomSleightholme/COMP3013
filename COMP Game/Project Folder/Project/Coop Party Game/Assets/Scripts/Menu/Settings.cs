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

    public Resolution[] resolutions;
    public List<string> options;

    public int currentResolutionIndex = 0;
    private void Start()
    {
        resolutions = Screen.resolutions;

        StartMusic();
        StartSFX();

        SFXSlider.value = sfx;
        MusicSlider.value = music;

        options = new List<string>();

        currentResolutionIndex = 0;
        for(int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if(resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }
    }

    public void Res(int number)
    {
        Resolution resolution = resolutions[number];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
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
