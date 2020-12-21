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

    [Header("SFX")]
    public Slider SFXSlider;
    public Image SFXSliderFill;
    public Text SFXHeader;
    public Image SFXButton;

    [Header("Resolution")]
    public Text ResText;
    public Image LeftResButton;
    public Image RightResButton;
    public Sprite RightOn;
    public Sprite RightOff;
    public Sprite LeftOn;
    public Sprite LeftOff;
    public Text ResolutionHeader;
    public Image ResoloutionButton;
    public int number;

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
        ResOff();

        Settings settings = FindObjectOfType<Settings>();

        number = settings.currentResolutionIndex;
    }

    private void Update()
    {
        ResUI();
    }

    public void MusicInteract()
    {
        MusicButton.color = ButtonOn;

        MusicHeader.color = On;
        MusicSlider.interactable = true;
        MusicSliderFill.color = On;
    }
    public void MusicInteractOff()
    {
        MusicButton.color = ButtonOff;

        MusicHeader.color = Off;
        MusicSlider.interactable = false;
        MusicSliderFill.color = Off;

    }
    public void SFXInteract()
    {
        SFXButton.color = ButtonOn;

        SFXHeader.color = On;
        SFXSlider.interactable = true;
        SFXSliderFill.color = On;
    }
    public void SFXInteractOff()
    {
        SFXButton.color = ButtonOff;

        SFXHeader.color = Off;
        SFXSlider.interactable = false;
        SFXSliderFill.color = Off;
    }

    public void ResOn()
    {
        ResolutionHeader.color = On;
        ResoloutionButton.color = ButtonOn;

        RightResButton.sprite = RightOn;
        LeftResButton.sprite = LeftOn;


        ResText.color = On;
    }

    public void ResOff()
    {
        ResolutionHeader.color = Off;
        ResoloutionButton.color = ButtonOff;

        RightResButton.sprite = RightOff;
        LeftResButton.sprite = LeftOff;

        ResText.color = Off;
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

    public void ResUI()
    {
        Settings settings = FindObjectOfType<Settings>();

        ResText.text = settings.options[number].ToString();


    }

    public void RightResUI()
    {
        Settings settings = FindObjectOfType<Settings>();

        if (number  < 1)
        {
            number = settings.options.Count - 1;
        }
        else
        {
            number-= 1;
        }

        settings.Res(number);
    }

    public void LeftResUI()
    {
        Settings settings = FindObjectOfType<Settings>();      

        if(number + 1 == settings.options.Count)
        {
            number = 0;
        }
        else
        {
            number++;
        }

        settings.Res(number);
    }
}
