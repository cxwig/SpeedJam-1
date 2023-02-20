using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GetterEnemyMove : MonoBehaviour, IGetterMove
{
    [SerializeField] private float _speed;
    [SerializeField] private float _range;
    [SerializeField] private SetterSneakingMove _target;
    [SerializeField] private Player _player;
    [SerializeField] private List<Transform> _points;
    [SerializeField] private NavMeshAgent _navMeshAgent;
    public bool IsEnemyMove { get; set; } = true;
    ChangerEnemyState changerEnemyState;
    private EnemyMove _enemyMove;
    public ReturnerEnemyPatrolVector ReturnerEnemyPatrolVector { get; private set; }
    public IMove Move { get; private set; }
    public List<Transform> Points { get => _points; set => _points = value; }

    public event Action OnChangeState;
    public event Action OnUpdate;
    private void Awake()
    {
        _enemyMove = new EnemyMove(_navMeshAgent, new ReturnerTargetVector(_target.transform, new ReturnerSpeed(_speed)));
        ReturnerEnemyPatrolVector = new ReturnerEnemyPatrolVector(transform, _points, new ReturnerSpeed(_speed));
        changerEnemyState = new ChangerEnemyState(_target, transform, _target.transform, _range, _enemyMove,
        new TransformMove(transform, ReturnerEnemyPatrolVector));
        GetChangerEnemyState();
    }
    private void GetChangerEnemyState()
    {
        IMove move = changerEnemyState.GetMove(_enemyMove,
new TransformMove(transform, ReturnerEnemyPatrolVector), _target.IsSneaking, _player.Behaviour is StoppedBehaviur);
        if (Move == null || move.GetType() != Move.GetType())
        {
            IsEnemyMove = move is EnemyMove;
            _navMeshAgent.isStopped = IsEnemyMove;
            Move = move;
            OnChangeState?.Invoke();
        }
    }
    public IMove GetMove() => Move;
    private void Update()
    {
        GetChangerEnemyState();
        OnUpdate?.Invoke();
    }
}
