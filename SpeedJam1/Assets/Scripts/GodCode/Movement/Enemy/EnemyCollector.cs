using System;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollector : MonoBehaviour
{
    [SerializeField] private List<GetterEnemyRotation> _getterEnemyRotations;
    public event Action OnEndGame;
    private void Awake()
    {
        _getterEnemyRotations.ForEach(e => e.Flashlight.OnTrigger += EndGame);
    }
    private void EndGame()
    {
        OnEndGame?.Invoke();
        Debug.Log("GAME OVER!");
    }
    private void OnDisable()
    {
        _getterEnemyRotations.ForEach(e => e.Flashlight.OnTrigger -= EndGame);
    }
}
