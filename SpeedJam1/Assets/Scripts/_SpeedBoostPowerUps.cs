using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _SpeedBoostPowerUps : MonoBehaviour
{
    [SerializeField] private float speedBoostAmount = 1.5f; // The amount by which the player's speed will be boosted
    public float powerupDuration = 10f; // The duration of the speed boost
    [SerializeField] private AudioClip powerupSound; // Sound effect to play when the powerup is collected
    public _PlayerMovement script;

    private bool hasBoosted = false;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && !hasBoosted)
        {
            Debug.Log("powerup collected");
            // Play the powerup sound
            AudioSource.PlayClipAtPoint(powerupSound, transform.position);

            // Boost the player's speed
            script.moveSpeed += speedBoostAmount;

            // Start a coroutine to remove the speed boost after the powerup duration has passed
            StartCoroutine(RemoveSpeedBoost());

            // Mark the powerup as collected
            hasBoosted = true;

            // Destroy the powerup object
            Destroy(gameObject);
        }
    }

    public IEnumerator RemoveSpeedBoost()
    {
        yield return new WaitForSeconds(powerupDuration);

        // Reduce the player's speed to normal
        script.moveSpeed -= speedBoostAmount;
    }
}

