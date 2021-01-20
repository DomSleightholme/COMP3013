using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class BumperUI : MonoBehaviour
{
    [Header("StartScreen")]
    public GameObject JoinScreen;
    public Text IndexCount;
    public Text player1Score;
    public Text player2Score;
    public int playerCount;

    [Header("End Screen")]
    public GameObject WinScreen;
    public Text PlayerWonText;
    public Text Player1Score;
    public Text Player2Score;
    public Text TimerText;
    public float Timer;
    public int P1Score;
    public int P2Score;

    public GameObject Scores;
    private ScoreManager scoreManager;
    private PlayerInputManager manager;
    private BumperMovement[] movement;
    private LevelTimer levelTimer;
   
    private void Start()
    {
        manager = FindObjectOfType<PlayerInputManager>();
        movement = FindObjectsOfType<BumperMovement>();
        scoreManager = FindObjectOfType<ScoreManager>();
        levelTimer = FindObjectOfType<LevelTimer>();

        Scores.SetActive(false);
        JoinScreen.SetActive(true);
        WinScreen.SetActive(false);
    }

    private void Update()
    {
        playerCount = manager.playerCount;
        IndexCount.text = manager.playerCount.ToString();

        if (manager.playerCount > 1)
        {
            JoinScreen.SetActive(false);
            WinScreen.SetActive(false);
            Scores.SetActive(true);
            StartGame();         
        }
        TimerText.text = Mathf.RoundToInt(Timer).ToString();
    }

    public void StartGame()
    {     
        movement[0].StartGame();
        movement[1].StartGame();
        levelTimer.GameRunning();
        player1Score.text = P1Score.ToString();
        player2Score.text = P2Score.ToString();
    }

    public void EndGame()
    {
        Scores.SetActive(false);
        JoinScreen.SetActive(false);
        WinScreen.SetActive(true);

        if(P1Score > P2Score)
        {
            PlayerWonText.text = "Player 1 Wins";
        }
        if (P1Score < P2Score)
        {
            PlayerWonText.text = "Player 2 Wins";
        }
        else
        {
            PlayerWonText.text = "Wowie! Tie";
        }
    
        Player1Score.text = P1Score.ToString();
        Player2Score.text = P2Score.ToString();
        
        if(Timer > 0)
        {
            Timer -= 1 * Time.deltaTime;
        }

        Return();
    }

    public void Return()
    {
        StartCoroutine(ReturnTimer());
    }
    IEnumerator ReturnTimer()
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene("TheBoard");
        scoreManager.playerList[0].PlayerScore += P1Score;
        scoreManager.playerList[1].PlayerScore += P2Score;
    }
}
