using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckpoint : MonoBehaviour
{
    [Header("Checkpoint Name")]
    public string CurrentCheckpoint;

    [Header("Checkpoint Spawn")]
    public GameObject Checkpoint_1;
    public GameObject Checkpoint_2;
    public GameObject Checkpoint_3;
    private void Start()
    {
        CurrentCheckpoint = "None";
    }

    //Collision Detection
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Checkpoint_1")
        {
            Debug.Log("Reached 1st Checkpoint!");
            CurrentCheckpoint = other.gameObject.name;
        }
        if (other.gameObject.name == "Checkpoint_2")
        {
            Debug.Log("Reached 2nd Checkpoint!");
            CurrentCheckpoint = other.gameObject.name;
        }
        if (other.gameObject.name == "Checkpoint_3")
        {
            Debug.Log("Reached 3rd Checkpoint!");
            CurrentCheckpoint = other.gameObject.name;
        }
    }
}
