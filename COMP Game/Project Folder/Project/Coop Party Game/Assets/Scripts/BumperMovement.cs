using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class BumperMovement : MonoBehaviour
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
    public ScoreManager score;
    bool p1LastHitPlayer;
    bool p2LastHitPlayer;
    public Transform spawn;
    public GameObject head;
    bool debouncer;

    [Header("Input Manager")]
    public int PlayerIndex;
    public BCInput controls;
    private PlayerInput playerInput;
    Vector2 movementInput;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        PlayerIndex = playerInput.playerIndex;

       controls = new BCInput();
       controls.PlayerMovement.Movement.performed += ctx => movementInput = ctx.ReadValue<Vector2>();
    }

    private void Start()
    {
        RB = GetComponent<Rigidbody>();
        debouncer = false;
        RB = GetComponent<Rigidbody>();       
    }

    private void FixedUpdate()
    {
        RB.drag = MovementDrag;
        RB.angularDrag = RotationDrag;

        float h = movementInput.x;
        float v = movementInput.y;
        PlayerAccleration(v);
        PlayerRotation(h);
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    void PlayerRotation(float Torque)
    {   
        RB.AddTorque(transform.up * TurnSpeed * TurnMulitpler * Torque);
    }

    void PlayerAccleration(float Accleration)
    {
        RB.AddRelativeForce(new Vector3(Vector3.forward.x, 0, Vector3.forward.z) * AcclerationSpeed * Accleration);
    }
    //-----------------------------------------------------------COLLISION----------------------------------------------------//
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player1")
        {
            if(debouncer == false)
            {
                debouncer = true;
                p1LastHitPlayer = true;
                score.addScore();
                StartCoroutine(debounce());
            }

        }

        if (collision.gameObject.tag == "Player2")
        {
            if (debouncer == false)
            {
                debouncer = true;
                p2LastHitPlayer = true;
                score.addScore();
                StartCoroutine(debounce());
            }

        }

        if (collision.gameObject.tag == "DeathBox")
        {
            if (debouncer == false)
            {
                debouncer = true;
                if (p1LastHitPlayer == true)
                {
                    score.addScore();
                    p1LastHitPlayer = false;
                    p2LastHitPlayer = false;
                }
                else if (p2LastHitPlayer == true)
                {
                    score.addScore();
                    p1LastHitPlayer = false;
                    p2LastHitPlayer = false;
                }
                StartCoroutine(debounce());
            }


            Instantiate(gameObject, spawn.transform.position, spawn.transform.rotation);
            Destroy(gameObject);
        }
        
    }

    IEnumerator debounce()
    {
        yield return new WaitForSeconds(1);
        debouncer = false;
    }

}
