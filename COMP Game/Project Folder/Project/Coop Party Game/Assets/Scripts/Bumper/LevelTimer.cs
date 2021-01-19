using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTimer : MonoBehaviour
{
    float timer = 30;


    private void Update()
    {
        timer -= 1 * Time.deltaTime;
        Debug.Log(timer);

        if(timer < 0)
        {
            SceneManager.LoadScene("TheBoard");
        }
    }
}
