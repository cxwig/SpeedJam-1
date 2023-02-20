using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    private PlayerInitializer _player;
    private SpriteRenderer _playerSpriteRenderer;
    public event Action OnExit;
    public event Action OnEnter;
    private bool _isEntered;
    [SerializeField] private float _radius = 4;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Trigger(other);
    }
    private void Trigger(Collider2D other)
    {
        other.TriggerEntity<PlayerInitializer>((player) =>
        {
            player.Player.Initialize(new StoppedBehaviur());
            player.GetterMove.ResetVelocity();
            _player = player;
            if (_playerSpriteRenderer == null)
            {
                _playerSpriteRenderer = player.GetComponent<SpriteRenderer>();
            }
            _playerSpriteRenderer.enabled = false;
            OnEnter?.Invoke();
            _isEntered = true;
        });
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (_isEntered)
            {
                _playerSpriteRenderer.enabled = true;
                _player.Initialize();
                OnExit?.Invoke();
                _isEntered = false;
            }
            else
            {
                Collider2D[] collider2Ds = Physics2D.OverlapCircleAll(transform.position,_radius);
                foreach (var item in collider2Ds)
                {
                    Trigger(item);
                }
            }
            
        }
    }
}