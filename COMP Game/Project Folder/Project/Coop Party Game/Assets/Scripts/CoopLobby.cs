using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class CoopLobby : MonoBehaviour
{
    public GameObject JoinScreen;
    public Text IndexCount;
    public Text player1Score;
    public Text player2Score;
    private ScoreManager scoreManager;
    private PlayerInputManager manager;
    private BumperMovement[] movement;
    public int playerCount;
    private void Start()
    {
        manager = FindObjectOfType<PlayerInputManager>();
        movement = FindObjectsOfType<BumperMovement>();
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void Update()
    {
        playerCount = manager.playerCount;
        IndexCount.text = manager.playerCount.ToString();

        if (manager.playerCount > 1)
        {
            JoinScreen.SetActive(false);
            StartGame();
        }
    }

    public void StartGame()
    {     
        movement[0].StartGame();
        movement[1].StartGame();

        player1Score.text = scoreManager.playerList[0].PlayerScore.ToString();
        player2Score.text = scoreManager.playerList[1].PlayerScore.ToString();
    }
}
