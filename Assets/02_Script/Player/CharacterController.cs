using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public event Action<Vector2> MoveEvent;
    
    public void CallBackMove(Vector2 _direction)
    {
        MoveEvent?.Invoke(_direction);
    }

}
