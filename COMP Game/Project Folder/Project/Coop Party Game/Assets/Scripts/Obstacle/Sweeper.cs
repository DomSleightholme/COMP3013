using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sweeper : MonoBehaviour
{
    [Range(10f, 100f)]
    public float Speed;
    public bool otherRotation;
    void Update()
    {
        if(otherRotation == false)
        {
            transform.Rotate(Vector3.up, Speed * Time.deltaTime, Space.Self);
        }
        else
        {
            transform.Rotate(Vector3.up, -Speed * Time.deltaTime, Space.Self);
        }
    }
}
