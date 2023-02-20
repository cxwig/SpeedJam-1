using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   // private IMove _move;
   // private IRotation _rotation;
    private IBehaviour _behaviour;
    public void Initialize(IBehaviour behaviour)//IMove move, IRotation rotation)
    {
        _behaviour = behaviour;
        //_move = move;
        //_rotation = rotation;
    }
    private void Update()
    {
        ///_rotation.Rotate();
    }
    private void FixedUpdate()
    {
        _behaviour.Behave();
        //_move?.Move();
    }
}
