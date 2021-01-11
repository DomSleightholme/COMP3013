using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [Header("Speed Variables")]
    public float Speed;

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
    }
    private void FixedUpdate()
    {
        //RB.velocity = Vector3.down * 10;
    }

    private void Update()
    {
        PlayerMovement(inputActions.ObstacleCourse.Acceleration.ReadValue<float>(), inputActions.ObstacleCourse.Turning.ReadValue<float>());
    }

    void PlayerMovement(float vertical, float turning)
    {
        RB.AddForce(transform.forward * vertical * Speed);
        RB.transform.Rotate(0.0f, turning, 0.0f);

        float turn = inputActions.ObstacleCourse.Turning.ReadValue<float>();
        if(turn == 0)
        {
            RB.freezeRotation = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("DeathBox"))
        {
            var checkpoint = FindObjectOfType<PlayerCheckpoint>();
            transform.position = checkpoint.SpawnCheckpoint.position;
            RB.velocity = Vector3.zero;
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
