using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnerControllableVector : IReturnerVector
{
    public ReturnerCurrentSpeed ReturnerSpeed { get; set; }
    private Transform _transform;
    public ReturnerControllableVector(Transform transform, ReturnerCurrentSpeed returnerSpeed)
    {
        _transform = transform;
        ReturnerSpeed = returnerSpeed;
    }
    public Vector3 ReturnVector() => new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),0) * ReturnerSpeed.ReturnSpeed();

}
