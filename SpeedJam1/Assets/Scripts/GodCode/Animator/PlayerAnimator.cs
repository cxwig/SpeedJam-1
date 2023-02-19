using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private GetterPlayerMove _getterPlayerMove;
    [SerializeField] private ChangerPlayerState _changerPlayerState;
    private bool _isMoving;
    private void Awake()
    {
        _changerPlayerState.OnSneak += PlaySneakAnimation;
        _changerPlayerState.OnMove += PlaySimpleAnimation;
    }
    private void PlaySneakAnimation()
    {
        _animator.SetBool("isSneaking", true);
    }
    private void PlaySimpleAnimation()
    {
        _animator.SetBool("isSneaking", false);        
    }
    private void Update()
    { 
         _isMoving = _getterPlayerMove.Move.ReturnerVector.ReturnVector() == Vector3.zero;
        _animator.SetBool("isMoving", _isMoving);
    }
    private void OnDisable()
    {
        _changerPlayerState.OnSneak -= PlaySneakAnimation;
        _changerPlayerState.OnMove -= PlaySimpleAnimation;
    }
}
