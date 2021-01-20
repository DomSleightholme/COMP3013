using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    [Header("Music")]
    public Slider MusicSlider;
    public Image MusicSliderFill;
    public Text MusicHeader;
    public Image MusicButton;
    public Image MusicSliderHandle;
    public Sprite MusicSliderOn;
    public Sprite MusicSliderOff;

    [Header("SFX")]
    public Slider SFXSlider;
    public Image SFXSliderFill;
    public Text SFXHeader;
    public Image SFXButton;
    public Image SFXSliderHandle;
    public Sprite SFXSliderOn;
    public Sprite SFXSliderOff;

    public Sprite RightOn;
    public Sprite RightOff;
    public Sprite LeftOn;
    public Sprite LeftOff;

    [Header("Windowed")]
    public Text WinMode;
    public Image LeftWinButton;
    public Image RightWinButton;
    public Sprite WindowedOn;
    public Sprite WindowedOff;
    public Text WindowedHeader;
    public Image WindowedButton;

    [Header("Return")]
    

    [Header("Colors")]
    public Color On;
    public Color Off;
    public Color ButtonOn;
    public Color ButtonOff;

    private void Start()
    {
        MusicSlider.interactable = false;
        SFXSlider.interactable = false;

        MusicInteractOff();
        SFXInteractOff();
        WindowOff();

        Settings settings = FindObjectOfType<Settings>();
    }


    public void MusicInteract()
    {
        MusicButton.color = ButtonOn;
        MusicSliderHandle.sprite = MusicSliderOn;
        MusicHeader.color = On;
        MusicSlider.interactable = true;
        MusicSliderFill.color = On;
    }
    public void MusicInteractOff()
    {
        MusicButton.color = ButtonOff;
        MusicSliderHandle.sprite = MusicSliderOff;
        MusicHeader.color = Off;
        MusicSlider.interactable = false;
        MusicSliderFill.color = Off;

    }
    public void SFXInteract()
    {
        SFXButton.color = ButtonOn;
        SFXSliderHandle.sprite = SFXSliderOn;
        SFXHeader.color = On;
        SFXSlider.interactable = true;
        SFXSliderFill.color = On;
    }
    public void SFXInteractOff()
    {
        SFXButton.color = ButtonOff;
        SFXSliderHandle.sprite = SFXSliderOff;
        SFXHeader.color = Off;
        SFXSlider.interactable = false;
        SFXSliderFill.color = Off;
    }

    public void WindowOn()
    {
        LeftWinButton.sprite = LeftOn;
        RightWinButton.sprite = RightOn;

        WindowedHeader.color = On;
        WindowedButton.color = ButtonOn;

        WinMode.color = On;
    }

    public void WindowOff()
    {
        WinMode.color = Off;

        LeftWinButton.sprite = LeftOff;
        RightWinButton.sprite = RightOff;

        WindowedHeader.color = Off;
        WindowedButton.color = ButtonOff;
    }

    public void WindowMode()
    {
        if(WinMode.text == "Off")
        {
            WinMode.text = "On";
        }
        else
        {
            WinMode.text = "Off";
        }
      
    }
}
