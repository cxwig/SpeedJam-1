using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Test : MonoBehaviour
{
    [SerializeField] private List<Transform> ppouints;
    [SerializeField] private NavMeshAgent _navMeshAgent;
    private void Awake()
    {
        _navMeshAgent.updateRotation = false;
        _navMeshAgent.updateUpAxis = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _navMeshAgent.SetDestination(ppouints.GetRandomElementOfList().position);
        }
    }
}
