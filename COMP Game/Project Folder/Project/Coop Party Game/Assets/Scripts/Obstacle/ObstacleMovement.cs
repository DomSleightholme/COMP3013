using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [Header("Speed Variables")]
    public float Speed;

    [Header("Transforms")]
    private Rigidbody RB;

    [Header("Drag")]
    public float MovementDrag;
    public float RotationDrag;

    [Header("Input System")]
    private PlayerControls inputActions;

    private void Awake()
    {
        inputActions = new PlayerControls();
    }

    private void Start()
    {
        RB = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        RB.drag = MovementDrag;
        RB.angularDrag = RotationDrag;
    }

    private void Update()
    {
        PlayerMovement(inputActions.Bumper.Accleration.ReadValue<float>(), inputActions.Bumper.Turning.ReadValue<float>());
    }

    void PlayerMovement(float vertical, float horizontal)
    {
        Vector3 movement = new Vector3(horizontal, 0.0f, vertical);
        RB.AddForce(movement * Speed);
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
