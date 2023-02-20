using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowerGameOver : MonoBehaviour
{
    [SerializeField] private EnemyCollector _enemyCollector;
    [SerializeField] private CanvasGroup _canvasGroup;
    [SerializeField] private Animator _animator;
    private bool _isTrigged;
    private void Start()
    {
        _enemyCollector.OnEndGame += DisplayGameOver;
    }
    private void DisplayGameOver()
    {
        if (_isTrigged == false)
        {
            _canvasGroup.ChangeStateOfCanvasGroup(true);
            _animator.SetTrigger("Fall");
        }
    }
    private void OnDisable()
    {
        _enemyCollector.OnEndGame -= DisplayGameOver;
    }
}
