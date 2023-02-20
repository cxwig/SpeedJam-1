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
    private bool _canFollow;
    private IMove _lastMove;
    public ChangerEnemyState(SetterSneakingMove setterSneakingMove, Transform transform, Transform target, float range, IMove followongTargetMove, IMove partolMove)
    {
        _transform = transform;
        _target = target;
        _range = range;
        _followingTargetMove = followongTargetMove;
        _partolMove = partolMove;
        _lastMove = _partolMove;
    }

    public IMove GetMove(IMove followongTargetMove, IMove partolMove, bool isSneaking, bool isStopped)
    {
        if (Vector2.Distance(_transform.position, _target.position) < _range && (_lastMove.GetType() == followongTargetMove.GetType() || isSneaking == false) && isStopped == false)
        {
            _lastMove = _followingTargetMove;
            return followongTargetMove;
        }
        _lastMove = partolMove;
        return partolMove;
    }
}
