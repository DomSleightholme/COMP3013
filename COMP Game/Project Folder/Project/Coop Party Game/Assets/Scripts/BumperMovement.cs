using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperMovement : MonoBehaviour
{
    [Header("Speed Variables")]
    public float AcclerationSpeed;
    public float TurnSpeed;

    [Header("Transforms")]
    private Rigidbody RB;

    public bool Player2;
    private void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        PlayerChosen();

        //Extra Gravity for the Players
        RB.AddForce(Vector3.down * Time.deltaTime * 10);
    }

    public void PlayerChosen()
    {
        if(Player2 == true)
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
        RB.AddTorque(transform.up * TurnSpeed * Torque);
    }

    void PlayerAccleration(float Accleration)
    {
        RB.AddRelativeForce(new Vector3(Vector3.forward.x, 0, Vector3.forward.z) * AcclerationSpeed * Accleration);
    }

}
