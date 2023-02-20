using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopperPlayer : MonoBehaviour
{
    [SerializeField] private PlayerInitializer _player;
    [SerializeField] private EnemyCollector _enemyCollector;
    private void Awake()
    {
        _enemyCollector.OnEndGame += StopPlayer;

    }
    private void StopPlayer()
    {
        _player.Player.Initialize(new StoppedBehaviur());
        _player.GetterMove.ResetVelocity();
    }
    private void OnDisable()
    {
        _enemyCollector.OnEndGame -= StopPlayer;
    }
}
