using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool Created;

    [Header("ModesActive")]
    public bool isLocal;
    public bool isOnline;

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
    }
}
