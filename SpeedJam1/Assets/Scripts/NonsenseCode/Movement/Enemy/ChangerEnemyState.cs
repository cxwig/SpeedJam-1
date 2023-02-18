using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangerEnemyState 
{
    private float _range = 10;
    private IMove _followingTargetMove;
    private IMove _partolMove;
    private Transform _transform;
    private Transform _target;
    public ChangerEnemyState(Transform transform, Transform target, float range, IMove followongTargetMove, IMove partolMove)
    {
        _transform = transform;
        _target = target;
        _range = range;
        _followingTargetMove = followongTargetMove;
        _partolMove = partolMove;
    }

    public IMove GetMove()
    {
       return Vector2.Distance(_transform.position, _target.position) < _range ? _followingTargetMove : _partolMove;
    }
}
