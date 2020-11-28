using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public Transform spawn;


    public bool isPlayer2;
    private void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        PlayerChosen();

        RB.drag = MovementDrag;
        RB.angularDrag = RotationDrag;
    }

    public void PlayerChosen()
    {
        if(isPlayer2 == true)
        {
            //When Input is applied, the movement methods are used
            PlayerRotation(Input.GetAxis("Horizontal1"));
            PlayerAccleration(Input.GetAxis("Vertical1"));
        }
        else
        {
            //When Input is applied, the movement methods are used
            PlayerRotation(Input.GetAxis("Horizontal"));
            PlayerAccleration(Input.GetAxis("Vertical"));
        }
    }

    void PlayerRotation(float Torque)
    {   
        RB.AddTorque(transform.up * TurnSpeed * TurnMulitpler * Torque);
    }

    void PlayerAccleration(float Accleration)
    {
        RB.AddRelativeForce(new Vector3(Vector3.forward.x, 0, Vector3.forward.z) * AcclerationSpeed * Accleration);
    }

    //Collisions
    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.CompareTag("DeathBox"))
        {
            Instantiate(gameObject, spawn.transform.position, spawn.transform.rotation);
            Destroy(gameObject);
        }
    }
}
