using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text Player1Score;
    public Text Player2Score;

    public int Player1;
    public int Player2;

    public void Update()
    {
        Player1Score.text = Player1.ToString();
        Player2Score.text = Player2.ToString();
    }
}
