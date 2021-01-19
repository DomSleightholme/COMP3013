﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class TheBoardUI : MonoBehaviour
{
    [Header("First Screen")]
    public GameObject Player1Panel;
    public Text Player1JoinText;
    public GameObject Player2Panel;
    public Text Player2JoinText;

    [Header("Second Screen")]
    public Text Player1Score;
    public Text Player2Score;

    [Header("Screens")]
    public GameObject Screen1;
    public GameObject Screen2;

    [Header("Classes")]
    private ScoreManager scoreManager;
    private PlayerInputManager manager;

    private void Start()
    {
        Screen1.SetActive(true);
        Screen2.SetActive(false);

        scoreManager = FindObjectOfType<ScoreManager>();
        manager = FindObjectOfType<PlayerInputManager>();
    }

    private void Update()
    {
        if(scoreManager.scoresActive == false)
        {
            if (manager.playerCount > 0)
            {
                Player1Panel.SetActive(false);
                Player1JoinText.text = "Player 1 Joined!";
            }
            if (manager.playerCount > 1)
            {
                Player2Panel.SetActive(false);
                Player2JoinText.text = "Player 2 Joined!";
                scoreManager.scoresActive = true;
                StartCoroutine(BoardScene());
            }
        }
        else
        {
            Screen2.SetActive(true);
            Screen1.SetActive(false);
        }

        BoardScreen();
    }

    public void BoardScreen()
    {
        Player1Score.text = scoreManager.playerList[0].PlayerScore.ToString();
        Player2Score.text = scoreManager.playerList[1].PlayerScore.ToString();
    }

    public void StartGames()
    {
        SceneManager.LoadScene("BumperCars");

    }

    IEnumerator BoardScene()
    {
        yield return new WaitForSeconds(2);
        Screen2.SetActive(true);
        Screen1.SetActive(false);
        scoreManager.StartScores();
    }
}