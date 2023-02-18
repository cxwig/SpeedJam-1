using System.Collections;
using System;
using UnityEngine;
using System.Threading;

public class ReturnerWrapperedSpeed : ReturnerCurrentSpeed
{
    private readonly ReturnerCurrentSpeed _returnerSpeed;
    private readonly float _speedFactor;
    public ReturnerWrapperedSpeed(float speedFactor,ReturnerCurrentSpeed returnerSpeed)
    {
        if (speedFactor <= 0)
        {
            throw new InvalidOperationException();
        }
        _speedFactor = speedFactor;
        _returnerSpeed = returnerSpeed;
       // Timer timer = new Timer(Reload, null, 600, Timeout.Infinite);
    }
   /* private void Reload(object obj)
    {
    }*/

    public override float ReturnSpeed() => _returnerSpeed.ReturnSpeed() * _speedFactor;



}
