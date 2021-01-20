using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ObstacleMovement : MonoBehaviour
{
    [Header("Speed Variables")]
    public float Speed;
    public float moveInput;
    public float turnInput;
    public bool GameStarted;

    [Header("Transforms")]
    private Rigidbody RB;
    public GameObject Spawn1;
    public GameObject Spawn2;

    [Header("Input System")]
    private PlayerControls inputActions;
    private PlayerInputManager manager;
    private ObstacleUI ui;

    private void Awake()
    {
        inputActions = new PlayerControls();
        RB = GetComponent<Rigidbody>();
        manager = FindObjectOfType<PlayerInputManager>();
        ui = FindObjectOfType<ObstacleUI>();
        StartSpawn();
    }

    private void StartSpawn()
    {
        Spawn1 = GameObject.Find("Player1Spawn");
        Spawn2 = GameObject.Find("Player2Spawn");

        if(manager.playerCount == 1)
        {
            transform.position = Spawn1.transform.position;
            this.gameObject.tag = "Player1";
        }
        if(manager.playerCount == 2)
        {
            transform.position = Spawn2.transform.position;
            this.gameObject.tag = "Player2";
        }
    }

    private void Update()
    {
        if(ui.GameOver == false)
        {
            PlayerMovement();
        }
    }

    public void SetMoveInput(float input)
    {
        moveInput = input;
    }
    public void SetTurnInput(float input)
    {
        turnInput = input;
    }

    void PlayerMovement()
    {
        RB.AddForce(transform.forward * moveInput * Speed);
        RB.transform.Rotate(0.0f, turnInput, 0.0f);

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
        if (other.gameObject.CompareTag("FinishLine"))
        {
            Debug.Log("Finished Line");
            ui.PlayerWon = this.tag;
            ui.GameOver = true;
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
