using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public void DisplayGameOver()
    {
        if (_isTrigged == false)
        {
            _canvasGroup.ChangeStateOfCanvasGroup(true);
            _animator.SetTrigger("Fall");
            StartCoroutine(CoolDown());
        }
    }
    private IEnumerator CoolDown()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("MainMenu");
    }

    private void OnDisable()
    {
        _enemyCollector.OnEndGame -= DisplayGameOver;
    }
}
