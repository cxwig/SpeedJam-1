using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private IMove _move;
    private IRotation _rotation;
    public void Initialize(IMove move, IRotation rotation)
    {
        _move = move;
        _rotation = rotation;
    }
    private void Update()
    {
        _rotation.Rotate();
    }
    private void FixedUpdate()
    {
        _move?.Move();
    }
}
