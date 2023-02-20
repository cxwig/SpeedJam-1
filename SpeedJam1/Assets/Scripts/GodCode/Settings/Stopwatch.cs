using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stopwatch : MonoBehaviour
{
    private bool _isStopped;
    public float CurrentTime { get; private set; }
    private void Update()
    {
        if (_isStopped == false)
        {
            CurrentTime += Time.deltaTime;

        }
    }
    public void IncreaseTime(RaiserValue raiserValue)
    {
        CurrentTime += raiserValue.AdditionalValue();
    }
    public void Stop() => _isStopped = true;
}
