using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityCamera : MonoBehaviour
{
    [SerializeField] private Stopwatch _stopwatch;
    [SerializeField] private float _additionalTime = 2;
    [SerializeField] private float _coolDown = 4;
    private bool _isCoolDown = true;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (_isCoolDown)
        {
            collision.TriggerEntity<Player>((player) =>
            {
                _stopwatch.IncreaseTime(new RaiserValue(_additionalTime));
                StartCoroutine(CoolDown());
            });
        }
    }
    private IEnumerator CoolDown()
    {
        _isCoolDown = false;
        yield return new WaitForSeconds(_coolDown);
        _isCoolDown = true;
    }
}
