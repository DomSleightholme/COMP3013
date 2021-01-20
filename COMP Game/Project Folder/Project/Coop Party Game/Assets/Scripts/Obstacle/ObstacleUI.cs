using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class ObstacleUI : MonoBehaviour
{
    public GameObject firstScreen;
    public GameObject secondScreen;
    public Text PlayerCount;
    public bool GameOver;
    public string PlayerWon;
    private PlayerInputManager manager;
    private ScoreManager scoreManager;

    [Header("WinScreen")]
    public Text Winner;
    public Text Player2Score;
    public Text Player1Score;
    public int P1;
    public int P2;

    private void Start()
    {
        manager = FindObjectOfType<PlayerInputManager>();
        scoreManager = FindObjectOfType<ScoreManager>();

        firstScreen.SetActive(true);
        secondScreen.SetActive(false);
    }
    private void Update()
    {
        PlayerCount.text = manager.playerCount.ToString();

        if(manager.playerCount == 2 && GameOver == false)
        {
            firstScreen.SetActive(false);           
        }
        if(GameOver == true)
        {
            secondScreen.SetActive(true);
            WinScreen();
        }
    }

    public void WinScreen()
    {
        Winner.text = PlayerWon.ToString();
        secondScreen.SetActive(true);

        if (PlayerWon == "Player1")
        {
            Winner.text = "Player 1 Won";
            Player1Score.text = "+ 20";
            Player2Score.text = "+ 5";
            P1 = 20;
            P2 = 5;
        }
        if (PlayerWon == "Player2")
        {
            Winner.text = "Player 2 Won";
            Player1Score.text = "+ 5";
            Player2Score.text = "+ 20";
            P1 = 5;
            P2 = 20;
        }
    }

    public void Return()
    {
        StartCoroutine(ReturnTimer());
        scoreManager.playerList[0].PlayerScore += P1;
        scoreManager.playerList[1].PlayerScore += P2;
    }

    public IEnumerator ReturnTimer()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("TheBoard");
    }
}
