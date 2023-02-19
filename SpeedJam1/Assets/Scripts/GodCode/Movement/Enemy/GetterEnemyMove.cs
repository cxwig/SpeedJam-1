using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GetterEnemyMove : MonoBehaviour, IGetterMove
{
    [SerializeField] private float _speed;
    [SerializeField] private float _range;
    [SerializeField] private SetterSneakingMove _target;
    [SerializeField] private Transform _firstPoint;
    [SerializeField] private Transform _secondPoint;
    [SerializeField] private NavMeshAgent _navMeshAgent;
    private IMove _previusMove;
    ChangerEnemyState changerEnemyState;
    public IMove Move { get; private set; }
    private void Awake()
    {
        changerEnemyState = new ChangerEnemyState(_target, transform, _target.transform, _range, new EnemyMove(_navMeshAgent, new ReturnerTargetVector(_target.transform, new ReturnerSpeed(_speed))),
new TransformMove(transform, new ReturnerEnemyPatrolVector(transform, _firstPoint, _secondPoint, new ReturnerSpeed(_speed))));
        GetChangerEnemyState();
    }
    private void GetChangerEnemyState()
    {
        IMove move = changerEnemyState.GetMove(new EnemyMove(_navMeshAgent, new ReturnerTargetVector(_target.transform, new ReturnerSpeed(_speed))),
new TransformMove(transform, new ReturnerEnemyPatrolVector(transform, _firstPoint, _secondPoint, new ReturnerSpeed(_speed))));
        if (Move == null || move.GetType() != Move.GetType())
        {
            _navMeshAgent.enabled = move is EnemyMove;
            Move = move;
        }
    }
    public IMove GetMove() => Move;
    private void Update()
    {
        GetChangerEnemyState();
    }
}
