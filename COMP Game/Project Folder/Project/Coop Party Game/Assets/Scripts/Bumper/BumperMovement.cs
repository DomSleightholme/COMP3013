using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BumperMovement : MonoBehaviour
{
    [Header("Speed Variables")]
    public float AcclerationSpeed;
    private float acclerationSpeed;
    public float TurnSpeed;
    private float turnSpeed;
    public float TurnMulitpler;
    private float turnMulitpler;
    public float moveInput = 0;
    public float turnInput = 0;

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
    public int playerIndex = 0;

    private void Awake()
    {
        inputActions = new PlayerControls();
    }
    private void Start()
    {
        RB = GetComponent<Rigidbody>();

        acclerationSpeed = 0;
        turnSpeed = 0;
        turnMulitpler = 0;
    }
    public int getPlayerIndex()
    {
        return playerIndex;
    }
    private void FixedUpdate()
    {
        RB.drag = MovementDrag;
        RB.angularDrag = RotationDrag;
    }
    private void Update()
    {
        RB.AddRelativeForce(new Vector3(Vector3.forward.x, 0, Vector3.forward.z) * acclerationSpeed * moveInput);
        RB.AddTorque(transform.up * turnSpeed * turnMulitpler * turnInput);
    }
    public void InputMove(float input)
    {
        moveInput = input;
    }
    public void InputTurn(float input)
    {
        turnInput = input;
    }

    public void StartGame()
    {
        acclerationSpeed = AcclerationSpeed;
        turnSpeed = TurnSpeed;
        turnMulitpler = TurnMulitpler;
    }
    //Collisions
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("DeathBox"))
        {
            transform.position = spawn.transform.position;
            transform.rotation = spawn.transform.rotation;
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            Vector3 knockbackDirection = RB.transform.position - collision.transform.position;
            RB.AddForce(knockbackDirection * knockbackForce);
        }
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
