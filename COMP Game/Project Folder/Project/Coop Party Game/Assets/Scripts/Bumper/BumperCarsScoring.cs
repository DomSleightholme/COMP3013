using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperCarsScoring : MonoBehaviour
{
    private ScoreManager scoreManager;
    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (collision.name != gameObject.name)
            {
                if(transform.parent.name == "Player 1")
                {
                    scoreManager.playerList[0].PlayerScore += 1;
                    Debug.Log("Player 1 score: " + scoreManager.playerList[0].PlayerScore);
                }
                if(transform.parent.name == "Player 2")
                {
                    scoreManager.playerList[1].PlayerScore += 1;
                    Debug.Log("Player 1 score: " + scoreManager.playerList[1].PlayerScore);
                }
            }
        }
    }
}
