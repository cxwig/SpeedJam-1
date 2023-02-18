using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnerMultiplySpeeds : ReturnerCurrentSpeed
{
    private List<ReturnerCurrentSpeed> _returnersSpeed = new List<ReturnerCurrentSpeed>();
    public override void Add(ReturnerCurrentSpeed returnerCurrentSpeed)
    {
        _returnersSpeed.Add(returnerCurrentSpeed);
    }

    public override void Remove(ReturnerCurrentSpeed returnerCurrentSpeed)
    {
        _returnersSpeed.Remove(returnerCurrentSpeed);
    }
    public override float ReturnSpeed()
    {
        float finalSpeed = 0;
        foreach (var item in _returnersSpeed)
        {
            finalSpeed += item.ReturnSpeed();
        }
        return finalSpeed;
    }
}
