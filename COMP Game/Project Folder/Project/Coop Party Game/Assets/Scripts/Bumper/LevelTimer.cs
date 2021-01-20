using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTimer : MonoBehaviour
{
    public float timer = 30;
    private BumperUI bumperUI;
    private void Start()
    {
        bumperUI = FindObjectOfType<BumperUI>();   
    }
    public void GameRunning()
    {
        timer -= 1 * Time.deltaTime;
        Debug.Log(timer);

        if (timer < 0)
        {
            bumperUI.EndGame();
            timer = 0;
        }
    }
}
