using System.Collections;
using System;
using UnityEngine;

public class FlashlightTrigger : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    public event Action OnTrigger;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.TriggerEntity<Player>((player) =>
        {
            OnTrigger?.Invoke();
            _enemy.enabled = false;
        });
    }
}
