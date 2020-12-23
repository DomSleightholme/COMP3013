using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCamera : MonoBehaviour
{
    public float CamSpeed;
    public bool isRotating;

    private void Start()
    {
        isRotating = true;
    }
    private void Update()
    {
        if(isRotating == true)
        {
            transform.Rotate(new Vector3(0, 1) * Time.deltaTime * CamSpeed);
        }
        if(isRotating == false)
        {
            transform.rotation = Quaternion.identity;
        }
    }
}
