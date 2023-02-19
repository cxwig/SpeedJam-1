using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class SecurityCamera : MonoBehaviour
{
    [SerializeField] private Stopwatch _stopwatch;
    [SerializeField] private VertexJitter _vertexJitter;
    [SerializeField] private float _additionalTime = 2;
    [SerializeField] private float _timeForShaking = 0.4f;
    [SerializeField] private float _coolDown = 4;
    [SerializeField] private float _radius = 3;
    private bool _isCoolDown = true;
    private void Update()
    {
        if (_isCoolDown)
        {
           Collider2D[] collider2Ds = Physics2D.OverlapCircleAll(transform.position, _radius);
            foreach (var item in collider2Ds)
            {
                item.TriggerEntity<Player>((player) =>
                {
                    Debug.Log("ShAKE!!");
                    _stopwatch.IncreaseTime(new RaiserValue(_additionalTime));
                    StartCoroutine(CoolDown());
                    StartCoroutine(Shake());
                });
            }
        }
    }
    private IEnumerator Shake()
    {
        float time = 0;
        while (time < _timeForShaking)
        {
            time += Time.deltaTime;
            _vertexJitter.ContinieMoving();
            yield return null;
        }
        _vertexJitter.Stop();
    }
    private IEnumerator CoolDown()
    {
        _isCoolDown = false;
        
        yield return new WaitForSeconds(_coolDown);
        _isCoolDown = true;
    }
}
