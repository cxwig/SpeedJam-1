using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxAnimator : MonoBehaviour
{
    [SerializeField] private Box _box;
    [SerializeField] private Animator _animator;
    private void Awake()
    {
        _box.OnEnter += PlayJumpIntoBoxAnimation;
        _box.OnExit += PlayOpenBoxAnimation;
    }
    private void PlayJumpIntoBoxAnimation()
    {
        _animator.SetTrigger("Jump");
    }
    private void PlayOpenBoxAnimation()
    {

    }
    private void OnDisable()
    {
        _box.OnEnter -= PlayJumpIntoBoxAnimation;
        _box.OnExit -= PlayOpenBoxAnimation;
    }
}
