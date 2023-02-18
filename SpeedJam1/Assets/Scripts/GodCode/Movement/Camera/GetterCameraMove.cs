using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterCameraMove : MonoBehaviour, IGetterMove
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed;
    public IMove Move { get; private set; }
    public IMove GetMove() => new PlayerMovement(transform, new ReturnerCameraVector(transform, _target, new ReturnerSpeed(_speed)));
}
