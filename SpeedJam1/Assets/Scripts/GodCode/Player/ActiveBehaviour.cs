using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveBehaviour : IBehaviour
{
    private IMove _move;
    private IRotation _rotation;
    public ActiveBehaviour(IMove move, IRotation rotation)
    {
        _move = move;
        _rotation = rotation;
    }
    public void Behave()
    {
        _move?.Move();
        _rotation.Rotate();
    }

    
}
