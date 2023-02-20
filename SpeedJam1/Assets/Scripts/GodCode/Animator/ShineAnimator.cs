using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShineAnimator : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private Vector2Int _bordersForCoolDown = new Vector2Int(6, 10);
    private int _coolDown;
    private float _time;
    public bool IsAbleToShine { get; set; } = true;
    private void Awake()
    {
        GetRandomCoolDown();
    }
    private void GetRandomCoolDown() => _coolDown = Random.Range(_bordersForCoolDown.x, _bordersForCoolDown.y);
    private void Update()
    {
        _time += Time.deltaTime;
        if (_time > _coolDown)
        {
            if (IsAbleToShine)
            {
                _animator.SetTrigger("Shine");
            }
            GetRandomCoolDown();
            _time = 0;
        }
    }
}
