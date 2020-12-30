using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HungerHippoControl : MonoBehaviour
{
    [Header("Speed Variables")]
    public float AcclerationSpeed;
    public float TurnSpeed;
    public float TurnMulitpler;

    [Header("Transforms")]
    private Rigidbody RB;

    [Header("Drag")]
    public float MovementDrag;
    public float RotationDrag;

    [Header("Collision")]
    public Transform spawn;
    public float knockbackForce;

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
        PlayerRotation(inputActions.Bumper.Turning.ReadValue<float>());
        PlayerAccleration(inputActions.Bumper.Accleration.ReadValue<float>());
    }

    void PlayerAccleration(float Accleration)
    {
        if(transform.position.z > 2)
        {
            RB.AddRelativeForce(new Vector3(Vector3.forward.x, 0, Vector3.forward.z) * AcclerationSpeed * Accleration);
        }
        else
        {
            AcclerationSpeed = 0;
        }
    }
    void PlayerRotation(float Torque)
    {
        RB.AddTorque(transform.up * TurnSpeed * TurnMulitpler * Torque);
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
