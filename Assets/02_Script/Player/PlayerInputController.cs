using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : CharacterController
{
    public void OnTdmMove(InputValue value)
    {
        Debug.Log("ют╥б!");
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallBackMove(moveInput);
    }
}
