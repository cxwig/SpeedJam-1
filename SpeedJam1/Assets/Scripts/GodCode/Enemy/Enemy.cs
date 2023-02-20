using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private IMove _move;
    private IRotation _rotation;
    [SerializeField] private NavMeshAgent _meshAgent;
    [SerializeField] private GetterEnemyMove _getterEnemyMove;
    public IMove Move { get => _move; private set => _move = value; }
    Vector2 poimt;
    private void Awake()
    {
        StartCoroutine(CoolDown());
    }
    public void Initialize(IMove move, IRotation rotation)
    {
        _move = move;
        _rotation = rotation;
    }
    private IEnumerator CoolDown()
    {
        yield return new WaitForSeconds(5);
        poimt = _getterEnemyMove.Points.GetRandomElementOfList().position;
        StartCoroutine(CoolDown());
    }
    private void Update()
    {
        _meshAgent.SetDestination(poimt);
      //  _move?.Move();
        _rotation?.Rotate();
    }
}
