using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HipposMovement : MonoBehaviour
{
    public float StartRotation;
    public float CapDecrease;
    public Vector3 EndRotationPlus;
    public Vector3 EndRotationSub;
    public Vector3 rotate;

    [Header("Transforms")]
    private Rigidbody RB;

    [Header("Input System")]
    private PlayerControls inputActions;

    private void Awake()
    {
        inputActions = new PlayerControls();
    }

    private void Start()
    {
        RB = GetComponent<Rigidbody>();
        StartRotation = transform.rotation.eulerAngles.y;

        EndRotationPlus.y = StartRotation + CapDecrease;
        EndRotationSub.y = StartRotation - CapDecrease;
    }

    private void Update()
    {
        Turning(inputActions.Hippos.Turning.ReadValue<float>());

        rotate.y = RB.transform.localEulerAngles.y;
    }

    void Turning(float turn)
    {
        RB.transform.Rotate(0.0f, turn, 0.0f);
    }

    //Will not work if this is not included
    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }
}
