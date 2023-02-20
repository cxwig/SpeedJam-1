using System;
using System.Collections.Generic;
using UnityEngine;

public class ReturnerEnemyPatrolVector : IReturnerVector
{
    private readonly float _radius = 2;
    private List<Transform> _points; 
    private Transform _transform;
    private Transform _currentPoint;
    public ReturnerCurrentSpeed ReturnerSpeed { get; set; }
    public Transform CurrentPoint { get => _currentPoint; set => _currentPoint = value; }
    public event Action OnGetNewPoint;
    public ReturnerEnemyPatrolVector(Transform transform, List<Transform> points, ReturnerCurrentSpeed returnerCurrentSpeed)
    {
        _transform = transform;
        _points = points;
        GetRandomCurrentPoint();
        ReturnerSpeed = returnerCurrentSpeed;
    }
    public Vector3 ReturnVector()
    {
        if (Vector2.Distance(_transform.position, _currentPoint.position) < _radius)
        {
            GetRandomCurrentPoint();
        }
       return Vector3.MoveTowards(_transform.position, _currentPoint.position,ReturnerSpeed.ReturnSpeed() * Time.deltaTime);
    }
    private void GetRandomCurrentPoint()
    {
        OnGetNewPoint?.Invoke();
        _currentPoint = _points.GetRandomElementOfList();
    }

}
