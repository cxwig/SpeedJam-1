using System.Collections;
using System;
using UnityEngine;

public class GetterPlayerMove : MonoBehaviour, IGetterMove
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    public IMove Move { get; private set; }
    public ReturnerCurrentSpeed ReturnerCurrentSpeed { get; private set; }

    public IMove GetMove()
    {
        if(Move == null)
        {
            _rigidbody2D.velocity = Vector2.zero;
            Move = new RigidbodyMovement(transform, _rigidbody2D, new ReturnerControllableVector(transform, new ReturnerMultiplySpeeds()));
            ReturnerCurrentSpeed = ReturnDeltaSpeed();
            Move.ReturnerVector.ReturnerSpeed.Add(ReturnerCurrentSpeed);
        }
        return Move;
    }
    public ReturnerCurrentSpeed ReturnDeltaSpeed(float factor = 1) => new ReturnerSpeed(_speed * factor);
}
