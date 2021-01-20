using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperCarsScoring : MonoBehaviour
{
    private BumperUI bumperUI;
    void Start()
    {
        bumperUI = FindObjectOfType<BumperUI>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (collision.name != gameObject.name)
            {
                if(transform.parent.name == "Player 1")
                {
                    bumperUI.P1Score += 1;
                    Debug.Log("Player 1 score: " + bumperUI.P1Score);
                }
                if(transform.parent.name == "Player 2")
                {
                    bumperUI.P2Score += 1;
                    Debug.Log("Player 1 score: " + bumperUI.P2Score);
                }
            }
        }
    }
}
