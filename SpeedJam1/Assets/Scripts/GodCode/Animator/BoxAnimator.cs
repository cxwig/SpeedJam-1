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
        _animator.SetBool("isOpened", false);
    }
    private void PlayOpenBoxAnimation()
    {
        _animator.SetBool("isOpened", true);
    }
    private void OnDisable()
    {
        _box.OnEnter -= PlayJumpIntoBoxAnimation;
        _box.OnExit -= PlayOpenBoxAnimation;
    }
}
