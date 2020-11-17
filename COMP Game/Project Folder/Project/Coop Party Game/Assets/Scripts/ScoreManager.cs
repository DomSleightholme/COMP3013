using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    int score;
    public Text scoreText;


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        updateScore();
    }

    public void addScore()
    {
        score++;
        updateScore();
    }

    void updateScore()
    {
        scoreText.text = score.ToString();
    }


}
