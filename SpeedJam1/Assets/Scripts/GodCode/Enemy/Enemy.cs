using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private IMove _move;
    private IRotation _rotation;
    public IMove Move { get => _move; private set => _move = value; }
    public void Initialize(IMove move, IRotation rotation)
    {
        _move = move;
        _rotation = rotation;
    }
    private void Update()
    {
        _move?.Move();
        _rotation?.Rotate();
    }
}
