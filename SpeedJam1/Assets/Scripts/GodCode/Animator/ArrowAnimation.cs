using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowAnimation : MonoBehaviour
{
    [SerializeField] private ShineAnimator _shineAnimator;
    [SerializeField] private _WindowPointer _windowPointer;
    [SerializeField] private Vector2 _size = new Vector2(0.7765307f, 0.7765307f);
    private Vector2 _startSize;
    [SerializeField] private Animator _animator;
    private void Awake()
    {
        _startSize = transform.localScale;
        Debug.Log("YEAH1");
    }
    public void PlayCross()
    {
        _shineAnimator.IsAbleToShine = false;
        transform.localScale = _size;
        Debug.Log("CROSS!");
        _animator.SetBool("isCross",true);
    }
    public void PlayArrow()
    {
        Debug.Log("ARROW!");
        transform.localScale = _startSize;
        _shineAnimator.IsAbleToShine = true;
        _animator.SetBool("isCross", false);
    }


}
