using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnerTargetVector : IReturnerVector
{
    private Transform _target;
    public ReturnerCurrentSpeed ReturnerSpeed { get; set; }
    public ReturnerTargetVector(Transform target, ReturnerCurrentSpeed returnerCurrentSpeed)
    {
        _target = target;
        ReturnerSpeed = returnerCurrentSpeed;
    }
    public Vector3 ReturnVector() => _target.position;

}
