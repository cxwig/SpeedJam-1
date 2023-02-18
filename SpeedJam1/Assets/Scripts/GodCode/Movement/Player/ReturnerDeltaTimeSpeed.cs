using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnerDeltaTimeSpeed : ReturnerCurrentSpeed
{

    private readonly ReturnerCurrentSpeed _returnerSpeed;
    public ReturnerDeltaTimeSpeed(ReturnerCurrentSpeed returnerSpeed)
    {
        _returnerSpeed = returnerSpeed;
    }
    public override float ReturnSpeed() => _returnerSpeed.ReturnSpeed() * Time.deltaTime;

}
