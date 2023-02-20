using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Test : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _navMeshAgent;
    [SerializeField] private Transform _target;
    private void Awake()
    {
        _navMeshAgent.updateRotation = false;
        _navMeshAgent.updateUpAxis = false;
    }
    private void Update()
    {
        _navMeshAgent.SetDestination(_target.position);
    }
}
