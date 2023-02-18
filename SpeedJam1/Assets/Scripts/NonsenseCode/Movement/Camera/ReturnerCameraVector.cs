using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnerCameraVector : IReturnerVector
{
    private readonly Transform _transform;
    private readonly Transform _playerTransform;
    private Vector3 _velocity = Vector3.zero;
    private readonly float _offsetZ = -10;
    public ReturnerCurrentSpeed ReturnerSpeed { get; set; }

    public ReturnerCameraVector(Transform transform, Transform playerTransform, ReturnerCurrentSpeed returnerSpeed)
    {
        _playerTransform = playerTransform;
        _transform = transform;
        ReturnerSpeed = returnerSpeed;
    }

    public Vector3 ReturnVector() => Vector3.SmoothDamp(_transform.position, new Vector3(_playerTransform.position.x, _playerTransform.position.y, _offsetZ), ref _velocity, ReturnerSpeed.ReturnSpeed());

}
