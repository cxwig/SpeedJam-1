using System;
using System.Collections.Generic;
using UnityEngine;
public class CollectorOfPowerUps : MonoBehaviour
{
    [SerializeField] private List<SpeedPowerUp> _speedPowerUps = new List<SpeedPowerUp>();
    public event Action OnPickUp;
    public event Action OnRemoveEffect;
    private void Awake()
    {
        _speedPowerUps.ForEach(e => e.OnPickUp += PickUp);
        _speedPowerUps.ForEach(e => e.OnRemoveEffect += RemoveEffect);
    }
    private void RemoveEffect(SpeedPowerUp speedPowerUp)
    {
        _speedPowerUps.Remove(speedPowerUp);
        OnRemoveEffect?.Invoke();
    }
    private void PickUp()
    {
        OnPickUp?.Invoke();
    }
    private void OnDisable()
    {
        _speedPowerUps.ForEach(e => e.OnPickUp -= PickUp);
        _speedPowerUps.ForEach(e => e.OnRemoveEffect -= RemoveEffect);
    }
}
