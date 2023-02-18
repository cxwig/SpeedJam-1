using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnerEnemyPatrolVector : IReturnerVector
{
    private Transform _firstPoint;
    private Transform _secondPoint;
    private Transform _transform;
    private Vector3 _currentPoint;
    public ReturnerCurrentSpeed ReturnerSpeed { get; set; }
    public ReturnerEnemyPatrolVector(Transform transform, Transform firstPoint, Transform secondPoint, ReturnerCurrentSpeed returnerCurrentSpeed)
    {
        _transform = transform;
        _firstPoint = firstPoint;
        _secondPoint = secondPoint;
        _currentPoint = firstPoint.position;
        float distanceToFirstPoint = Vector2.Distance(_transform.position, _firstPoint.position);
        float distanceToSecondPoint = Vector2.Distance(_transform.position, _secondPoint.position);
        if (distanceToFirstPoint > distanceToSecondPoint)
        {
            _currentPoint = secondPoint.position;
        }
        ReturnerSpeed = returnerCurrentSpeed;
    }
    public Vector3 ReturnVector()
    {
        if (_transform.position == _secondPoint.position)
        {
            _currentPoint = _firstPoint.position;
        }
        else if (_transform.position == _firstPoint.position)
        {
            _currentPoint = _secondPoint.position;
        }
       return Vector3.MoveTowards(_transform.position, _currentPoint,ReturnerSpeed.ReturnSpeed() * Time.deltaTime);
    }

}
