using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour
{
    public bool isFalse;
    private Rigidbody RB;

    private void Start()
    {
        RB = GetComponent<Rigidbody>();
        RB.isKinematic = true;
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player") && isFalse == true)
        {
            RB.isKinematic = false;
            var Box = GetComponent<BoxCollider>();
            Box.isTrigger = true;
        }
    }
}
