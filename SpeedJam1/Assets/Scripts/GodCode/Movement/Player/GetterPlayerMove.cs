using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterPlayerMove : MonoBehaviour, IGetterMove
{
    [SerializeField] private float _speed;
    public IMove Move { get; private set; }
    public IMove GetMove()
    {
        if(Move == null)
        {
            Move = new PlayerMovement(transform, new ReturnerControllableVector(transform, new ReturnerMultiplySpeeds()));
            Move.ReturnerVector.ReturnerSpeed.Add(new ReturnerDeltaTimeSpeed(new ReturnerSpeed(_speed)));
        }
        return Move;
    }

}
