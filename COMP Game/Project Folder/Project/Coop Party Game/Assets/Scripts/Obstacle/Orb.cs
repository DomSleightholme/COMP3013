using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour
{
    public string PlayerName;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == PlayerName)
        {
            GivePlayer();
        }
    }

    void GivePlayer()
    {
        Destroy(gameObject);
    }
}
