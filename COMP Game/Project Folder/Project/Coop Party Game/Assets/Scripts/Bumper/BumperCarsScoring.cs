using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperCarsScoring : MonoBehaviour
{
    private ScoreManager scoreManager;
    public int PlayerScore;
    
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
                    scoreManager.Player1++;
                }
                if(transform.parent.name == "Player 2")
                {
                    scoreManager.Player2++;
                }
            }
        }
    }
}
