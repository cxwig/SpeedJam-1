using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnPickUp : MonoBehaviour
{
    [SerializeField] private AudioClip _powerupSound;
    [SerializeField] private SpeedPowerUp _speedPowerUp;
    private void Awake()
    {
        _speedPowerUp.OnPickUp += PlaySound;
    }
    private void PlaySound()
    {
        AudioSource.PlayClipAtPoint(_powerupSound, transform.position);
    }
    private void OnDisable()
    {
        _speedPowerUp.OnPickUp -= PlaySound;
    }
}
