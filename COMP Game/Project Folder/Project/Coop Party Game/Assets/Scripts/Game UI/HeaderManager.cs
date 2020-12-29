using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeaderManager : MonoBehaviour
{
    public int PlayerCount;

    public List<Transform> PlayerHeaders;

    private void Start()
    {
        for(int i = 0; i < PlayerHeaders.Count; i++)
        {
            PlayerHeaders[i].gameObject.SetActive(false);
        }

        if (PlayerCount == 2)
        {
            TwoPlayers();
        }
        if(PlayerCount == 3)
        {
            ThreePlayers();
        }
        if (PlayerCount == 4)
        {
            FourPlayers();
        }
        if(PlayerCount == 5)
        {
            FivePlayers();
        }
        if(PlayerCount == 6)
        {
            SixPlayers();
        }
        if(PlayerCount == 7)
        {
            SevenPlayers();
        }
        if(PlayerCount == 8 || PlayerCount > 8)
        {
            PlayerCount = 8;
            EightPlayers();
        }
    }

    private void Update()
    {
        //Removes Headers if not active
        for(var i = PlayerHeaders.Count - 1; i >=0; i--)
        {
            if(PlayerHeaders[i] == null)
            {
                PlayerHeaders.RemoveAt(i);
            }
        }
    }

    void TwoPlayers()
    {
        //Set Headers needed Active
        PlayerHeaders[0].gameObject.SetActive(true);
        PlayerHeaders[3].gameObject.SetActive(true);

        //Rename Headers active if needed
        PlayerHeaders[3].gameObject.name = "Player Header 2";

        //Delete other Headers from the list
        for (int i = 0; i < PlayerHeaders.Count; i++)
        {
            if (PlayerHeaders[i].gameObject.activeInHierarchy)
            {
                Debug.Log("Player " + i + " is active");
            }
            else
            {
                Destroy(PlayerHeaders[i].gameObject);        
            }       
        } 
    }

    void ThreePlayers()
    {
        //Set Headers needed Active
        PlayerHeaders[0].gameObject.SetActive(true);
        PlayerHeaders[1].gameObject.SetActive(true);
        PlayerHeaders[3].gameObject.SetActive(true);

        //Rename Headers active if needed
        PlayerHeaders[1].gameObject.name = "Player Header 2";
        PlayerHeaders[3].gameObject.name = "Player Header 3";

        //Change Position of Headers needed
        PlayerHeaders[1].transform.localPosition = new Vector2(0, 482);

        //Delete other Headers from the list
        for (int i = 0; i < PlayerHeaders.Count; i++)
        {
            if (PlayerHeaders[i].gameObject.activeInHierarchy)
            {
                Debug.Log("Player " + i + " is active");
            }
            else
            {
                Destroy(PlayerHeaders[i].gameObject);
            }
        }
    }

    void FourPlayers()
    {
        //Set Headers needed Active
        PlayerHeaders[0].gameObject.SetActive(true);
        PlayerHeaders[3].gameObject.SetActive(true);
        PlayerHeaders[4].gameObject.SetActive(true);
        PlayerHeaders[7].gameObject.SetActive(true);

        //Rename Headers active if needed
        PlayerHeaders[3].gameObject.name = "Player Header 2";
        PlayerHeaders[4].gameObject.name = "Player Header 3";
        PlayerHeaders[7].gameObject.name = "Player Header 4";

        //Delete other Headers from the list
        for (int i = 0; i < PlayerHeaders.Count; i++)
        {
            if (PlayerHeaders[i].gameObject.activeInHierarchy)
            {
                Debug.Log("Player " + i + " is active");
            }
            else
            {
                Destroy(PlayerHeaders[i].gameObject);
            }
        }
    }

    void FivePlayers()
    {
        //Set Headers needed Active
        PlayerHeaders[0].gameObject.SetActive(true);
        PlayerHeaders[1].gameObject.SetActive(true);
        PlayerHeaders[3].gameObject.SetActive(true);
        PlayerHeaders[4].gameObject.SetActive(true);
        PlayerHeaders[7].gameObject.SetActive(true);

        //Rename Headers active if needed
        PlayerHeaders[1].gameObject.name = "Player Header 2";
        PlayerHeaders[3].gameObject.name = "Player Header 3";
        PlayerHeaders[4].gameObject.name = "Player Header 4";
        PlayerHeaders[7].gameObject.name = "Player Header 5";

        //Change Position of Headers needed
        PlayerHeaders[1].transform.localPosition = new Vector2(0, 482);

        //Delete other Headers from the list
        for (int i = 0; i < PlayerHeaders.Count; i++)
        {
            if (PlayerHeaders[i].gameObject.activeInHierarchy)
            {
                Debug.Log("Player " + i + " is active");
            }
            else
            {
                Destroy(PlayerHeaders[i].gameObject);
            }
        }
    }

    void SixPlayers()
    {
        //Set Headers needed Active
        PlayerHeaders[0].gameObject.SetActive(true);
        PlayerHeaders[1].gameObject.SetActive(true);
        PlayerHeaders[3].gameObject.SetActive(true);
        PlayerHeaders[4].gameObject.SetActive(true);
        PlayerHeaders[5].gameObject.SetActive(true);
        PlayerHeaders[7].gameObject.SetActive(true);

        //Rename Headers active if needed
        PlayerHeaders[1].gameObject.name = "Player Header 2";
        PlayerHeaders[3].gameObject.name = "Player Header 3";
        PlayerHeaders[4].gameObject.name = "Player Header 4";
        PlayerHeaders[5].gameObject.name = "Player Header 5";
        PlayerHeaders[7].gameObject.name = "Player Header 6";

        //Change Position of Headers needed
        PlayerHeaders[1].transform.localPosition = new Vector2(0, 482);
        PlayerHeaders[5].transform.localPosition = new Vector2(0, -482);

        //Delete other Headers from the list
        for (int i = 0; i < PlayerHeaders.Count; i++)
        {
            if (PlayerHeaders[i].gameObject.activeInHierarchy)
            {
                Debug.Log("Player " + i + " is active");
            }
            else
            {
                Destroy(PlayerHeaders[i].gameObject);
            }
        }
    }

    void SevenPlayers()
    {
        //Set Headers needed Active
        PlayerHeaders[0].gameObject.SetActive(true);
        PlayerHeaders[1].gameObject.SetActive(true);
        PlayerHeaders[2].gameObject.SetActive(true);
        PlayerHeaders[3].gameObject.SetActive(true);
        PlayerHeaders[4].gameObject.SetActive(true);
        PlayerHeaders[6].gameObject.SetActive(true);
        PlayerHeaders[7].gameObject.SetActive(true);

        //Rename Headers active if needed
        PlayerHeaders[1].gameObject.name = "Player Header 2";
        PlayerHeaders[2].gameObject.name = "Player Header 3";
        PlayerHeaders[3].gameObject.name = "Player Header 4";
        PlayerHeaders[4].gameObject.name = "Player Header 5";
        PlayerHeaders[6].gameObject.name = "Player Header 6";
        PlayerHeaders[7].gameObject.name = "Player Header 7";

        //Change Position of Headers needed
        PlayerHeaders[6].transform.localPosition = new Vector2(0, -482);

        //Delete other Headers from the list
        for (int i = 0; i < PlayerHeaders.Count; i++)
        {
            if (PlayerHeaders[i].gameObject.activeInHierarchy)
            {
                Debug.Log("Player " + i + " is active");
            }
            else
            {
                Destroy(PlayerHeaders[i].gameObject);
            }
        }
    }

    void EightPlayers()
    {
        for(int i = 0; i < PlayerHeaders.Count; i++)
        {
            PlayerHeaders[i].gameObject.SetActive(true);
        }
    }
}
