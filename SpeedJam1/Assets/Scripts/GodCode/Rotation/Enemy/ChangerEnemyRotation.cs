using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangerEnemyRotation : MonoBehaviour
{
    [SerializeField] private GetterEnemyMove _getterEnemyMove;
    [SerializeField] private GetterEnemyRotation _getterEnemyRotation;
    [SerializeField] private Transform _target;
    private void Awake()
    {
        //_getterEnemyMove.OnChangeState += ChangeState;
        _getterEnemyMove.OnUpdate += ChangeState;
    }
    private void GetNewPoint()
    {

    }
    private void FixedUpdate()
    {
    }
    private void ChangeState()
    {
        Debug.Log("1!!!!!!!!!!!!!!!!!1111" + _getterEnemyMove.ReturnerEnemyPatrolVector.CurrentPoint.name);
        _getterEnemyRotation.CurrentPoint = _getterEnemyMove.IsEnemyMove ?  _target : _getterEnemyMove.ReturnerEnemyPatrolVector.CurrentPoint;
    }
    private void OnDisable()
    {
        _getterEnemyMove.OnUpdate -= ChangeState;
    }
}
