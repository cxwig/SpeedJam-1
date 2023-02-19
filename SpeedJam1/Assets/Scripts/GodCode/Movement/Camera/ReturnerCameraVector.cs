using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnerCameraVector : IReturnerVector
{
    private readonly Transform _transform;
    private readonly Transform _playerTransform;
    private Vector3 _velocity = Vector3.zero;
    private readonly float _offsetZ = -10;
    private readonly Vector2 _offset = new Vector2(0, -2);
    public ReturnerCurrentSpeed ReturnerSpeed { get; set; }

    public ReturnerCameraVector(Transform transform, Transform playerTransform, ReturnerCurrentSpeed returnerSpeed)
    {
        _playerTransform = playerTransform;
        _transform = transform;
        ReturnerSpeed = returnerSpeed;
    }

    public Vector3 ReturnVector() => new Vector3
        (GetPlayerPosiotion(_transform.position.x, _playerTransform.position.x + _offset.x, _velocity.x),
        GetPlayerPosiotion(_transform.position.y, _playerTransform.position.y + _offset.y, _velocity.y),
        _offsetZ);
    private float GetPlayerPosiotion(float position, float playerPositon, float velocity) => Mathf.SmoothDamp(position, playerPositon, ref velocity, ReturnerSpeed.ReturnSpeed());

}
