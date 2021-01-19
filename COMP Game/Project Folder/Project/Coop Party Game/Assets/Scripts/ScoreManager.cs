using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public bool Created;
    public List<Player> playerList = new List<Player>(2);

    private void Awake()
    {
        if (!Created)
        {
            DontDestroyOnLoad(this.gameObject);
            Created = true;
        }
        else
        {
            Destroy(this);
        }

        StartScores();
    }

    public class Player
    {
        public int PlayerNumber;
        public int PlayerScore;

        public Player(int _playerNumber, int _PlayerScore)
        {
            PlayerNumber = _playerNumber;
            PlayerScore = _PlayerScore;
        }
    }

    public void StartScores()
    {
        playerList.Add(new Player(1, 0));
        playerList.Add(new Player(2, 0));

        Debug.Log(playerList.Count);
    }

    public void ResetScores()
    {
        List<Player> playerList = new List<Player>(2);

        playerList.Add(new Player(1, 0));
        playerList.Add(new Player(2, 0));
    }
}
