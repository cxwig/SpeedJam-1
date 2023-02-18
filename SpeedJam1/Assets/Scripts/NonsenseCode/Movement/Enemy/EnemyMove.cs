using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyMove : IMove
{

    private NavMeshAgent _navMeshAgent;
    public IReturnerVector ReturnerVector { get; set; }
    public EnemyMove(NavMeshAgent navMeshAgent, IReturnerVector returnerVector)
    {
        _navMeshAgent = navMeshAgent;
        ReturnerVector = returnerVector;
        _navMeshAgent.updateRotation = false;
        _navMeshAgent.updateUpAxis = false;
        _navMeshAgent.speed = ReturnerVector.ReturnerSpeed.ReturnSpeed();
    }
    public void Move()
    {
        _navMeshAgent.SetDestination(ReturnerVector.ReturnVector());
    }
}
