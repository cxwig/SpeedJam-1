using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableCamera : MonoBehaviour
{
    private IMove _move;
    public IMove Move { get => _move; private set => _move = value; }
    public void Initialize(IMove move)
    {
        _move = move;
    }
    private void FixedUpdate()
    {
        _move?.Move();
    }
}
