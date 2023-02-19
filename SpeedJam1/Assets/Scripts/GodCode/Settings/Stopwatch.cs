using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stopwatch : MonoBehaviour
{
    public float CurrentTime { get; private set; }
    private void Update()
    {
        CurrentTime += Time.deltaTime;
    }
    public void IncreaseTime(RaiserValue raiserValue)
    {
        CurrentTime += raiserValue.AdditionalValue();
    }
}
