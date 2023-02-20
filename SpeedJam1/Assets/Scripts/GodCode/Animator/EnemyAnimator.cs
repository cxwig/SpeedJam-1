using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimator : MonoBehaviour
{
    [SerializeField] private GetterEnemyMove _getterEnemyMove;
    [SerializeField] private Animator _animator;
    private void Awake()
    {
        _getterEnemyMove.OnChangeState += PlayMoveAnimation;
    }
    private void PlayMoveAnimation()
    {
        _animator.SetBool("isRunning", _getterEnemyMove.IsEnemyMove);
    }
    private void OnDisable()
    {
        _getterEnemyMove.OnChangeState -= PlayMoveAnimation;
    }
}
