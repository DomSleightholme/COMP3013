using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScreen : MonoBehaviour
{
    [Header("Text")]
    public Text Start;
    public Text Options;
    public Text Quit;

    [Header("Color")]
    public Color StartOn;
    public Color OptionsOn;
    public Color QuitOn;
    public Color Off;

    public void OnStart()
    {
        Start.color = StartOn;
    }
    public void OffStart()
    {
        Start.color = Off;
    }

    public void OnOptions()
    {
        Options.color = OptionsOn;
    }

    public void OffOptions()
    {
        Options.color = Off;
    }

    public void OnQuit()
    {
        Quit.color = QuitOn;
    }

    public void OffQuit()
    {
        Quit.color = Off;
    }
}
