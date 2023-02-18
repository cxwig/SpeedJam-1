using System.Collections;
using System;
using UnityEngine;

public class SpeedPowerUp : MonoBehaviour
{
    [SerializeField] private float _speedFactor = 1.3f;
    [SerializeField] private float _duration = 5;
    private ReturnerCurrentSpeed _returnerCurrentSpeed;
    private bool _isUsed = false;
    public event Action OnPickUp;
    public void OnTriggerEnter2D(Collider2D other)
    {
        other.TriggerEntity<PlayerInitializer>((player) =>
        {
            if (_isUsed == false)
            {
                _isUsed = true;
                _returnerCurrentSpeed = new ReturnerDeltaTimeSpeed(new ReturnerSpeed(_speedFactor));
                player.GetterMove.Move.ReturnerVector.ReturnerSpeed.Add(_returnerCurrentSpeed);
                player.Initialize();
                gameObject.GetComponent<Renderer>().enabled = false;
                OnPickUp?.Invoke();
                StartCoroutine(RemoveSpeedBoost(player));
            }
        });
    }
    public IEnumerator RemoveSpeedBoost(PlayerInitializer player)
    {
        yield return new WaitForSeconds(_duration);
        player.GetterMove.Move.ReturnerVector.ReturnerSpeed.Remove(_returnerCurrentSpeed);
        Destroy(gameObject);
    }

}
