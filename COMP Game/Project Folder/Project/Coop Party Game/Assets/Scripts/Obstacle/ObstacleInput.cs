using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Linq;
using static UnityEngine.InputSystem.InputAction;

public class ObstacleInput : MonoBehaviour
{
    private PlayerInput playerInput;
    private ObstacleMovement movement;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        movement = FindObjectOfType<ObstacleMovement>();
    }

    public void OnMove(CallbackContext context)
    {
        if (movement != null)
        {
            movement.SetMoveInput(context.ReadValue<float>());
        }
    }

    public void OnTurn(CallbackContext context)
    {
        if (movement != null)
        {
            movement.SetTurnInput(context.ReadValue<float>());
        }
    }
}
