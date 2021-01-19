using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class BumperInputHandler : MonoBehaviour
{
    private PlayerInput playerInput;
    private BumperMovement movement;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        var movers = FindObjectsOfType<BumperMovement>();
        var index = playerInput.playerIndex;
        movement = movers.FirstOrDefault(m => m.getPlayerIndex() == index);
    }

    public void OnMove(CallbackContext context)
    {
        if(movement != null)
        {
            movement.InputMove(context.ReadValue<float>());
        }
    }

    public void OnTurn(CallbackContext context)
    {
       if(movement != null)
        {
            movement.InputTurn(context.ReadValue<float>());
        }
    }
}
