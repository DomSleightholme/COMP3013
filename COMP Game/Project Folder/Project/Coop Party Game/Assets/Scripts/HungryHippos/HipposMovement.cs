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

    public Vector3 startPos;
    public Vector3 movePos;
    public Vector3 moveEndPos;
    public Vector3 movement;

    public float speed;

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
        startPos = transform.position;

        EndRotationPlus.y = StartRotation + CapDecrease;
        EndRotationSub.y = StartRotation - CapDecrease;
    }

    private void Update()
    {
        Turning(inputActions.Hippos.Turning.ReadValue<float>());

        rotate.y = RB.transform.localEulerAngles.y;

        movement.z = RB.transform.localPosition.z;
        movement.x = RB.transform.localPosition.x;

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
