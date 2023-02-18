using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GetterEnemyMove : MonoBehaviour, IGetterMove
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _target;
    [SerializeField] private NavMeshAgent _navMeshAgent;
    public IMove Move { get; private set; }
    public IMove GetMove()
    {
        if (Move == null)
        {
            Move = new EnemyMove(_navMeshAgent, new ReturnerTargetVector(_target,new ReturnerSpeed(_speed)));
        }
        return Move;
    }
}
