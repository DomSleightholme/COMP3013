using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FontColour : MonoBehaviour
{
    public Text TextUI;
    public Color On;
    public Color Off;

    public void HoverOn()
    {
        TextUI.color = On;
    }
    public void HoverOff()
    {
        TextUI.color = Off;
    }
}
