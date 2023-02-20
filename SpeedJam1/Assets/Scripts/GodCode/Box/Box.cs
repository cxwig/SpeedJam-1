using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField] private SetterSneakingMove _sneakingMove;
    private bool _isEntered;
    [SerializeField] private Animator _animator;
    private PlayerInitializer _player;
    [SerializeField] private float _radius = 4;
    [SerializeField] private BoxCollider2D _boxCollider2D;
    private SpriteRenderer _playerSpriteRenderer;
    public event Action OnExit;
    public event Action OnEnter;
    private void OnTriggerEnter2D(Collider2D other)
    {
        other.TriggerEntity<PlayerInitializer>((player) =>
        {
            player.Player.Initialize(new StoppedBehaviur());
            player.GetterMove.ResetVelocity();
            _player = player;
            _isEntered = true;
            if (_playerSpriteRenderer == null)
            {
                _playerSpriteRenderer = player.GetComponent<SpriteRenderer>();
            }
            _playerSpriteRenderer.enabled = false;
            OnEnter?.Invoke();
        });
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && _isEntered)
        {
            _playerSpriteRenderer.enabled = true;
            _player.Initialize();
            _isEntered = false;
            OnExit?.Invoke();
        }
    }
}