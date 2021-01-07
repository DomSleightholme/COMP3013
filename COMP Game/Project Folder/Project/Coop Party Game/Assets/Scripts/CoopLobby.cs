using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoopLobby : MonoBehaviour
{
    public int PlayerCount;
    public List<bool> PlayerReady;

    [Header("Lists")]
    public List<GameObject> PlayerActive;
    public List<GameObject> PlayerOffline;
    public List<GameObject> PlayerReadyImage;
    public GameObject LoginCode;

    [Header("Animator")]
    public Animator SceneTrans;
    public GameObject Mask;

    GameManager gameManager;

    private void Start()
    {
        SceneTrans.SetTrigger("FadeOut");
        StartCoroutine(MaskOff());

        gameManager = FindObjectOfType<GameManager>();
        if(gameManager.isOnline == true)
        {
            LoginCode.SetActive(true);
        }
        else
        {
            LoginCode.SetActive(false);
        }

        PlayerCount = 1;

        int i = 0;

        while (i < PlayerActive.Count)
        {
            PlayerActive[i].SetActive(false);
            PlayerOffline[i].SetActive(true);
            i++;
        }
    }

    private void Update()
    {
        if(PlayerCount > 8)
        {
            PlayerCount = 8;
        }

        TrackPlayerUI();
    }

    public void PlayerStartReady()
    {
        int PlayersReady = 0;
        for (int i = 0; i < PlayerCount; i++)
        {
            if (PlayerReady[i] == true)
            {
                PlayersReady++;
            }
            if (PlayerReady[i] == false)
            {
                Debug.Log("off");
            }
        }

        if (PlayersReady == PlayerCount)
        {
            Debug.Log("Start");
        }
        Debug.Log(PlayersReady);
    }

    void TrackPlayerUI()
    {
        int currentCount = PlayerCount -1;
        if (currentCount > 0)
        {
            int i = 0;
            while(i < currentCount)
            {
                PlayerActive[i].SetActive(true);
                PlayerOffline[i].SetActive(false);
               
                i++;
            }
        }
    
    }

    IEnumerator MaskOff()
    {
        yield return new WaitForSeconds(1.5f);
        Mask.SetActive(false);
    }
}
