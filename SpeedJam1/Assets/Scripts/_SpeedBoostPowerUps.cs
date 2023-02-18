using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _SpeedBoostPowerUps : MonoBehaviour
{
    [SerializeField] private float speedBoostAmount = 1.5f; // Amount
    public float powerupDuration = 10f; // The duration
    [SerializeField] private AudioClip powerupSound; // Sound effect
    public _PlayerMovement script;

    private bool hasBoosted = false;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && !hasBoosted)
        {
            Debug.Log("powerup collected");
            //sound effect
            AudioSource.PlayClipAtPoint(powerupSound, transform.position);

            // Speed boost
            script.moveSpeed += speedBoostAmount;

            // Start a coroutine
            StartCoroutine(RemoveSpeedBoost());

            // Mark the powerup as collected
            hasBoosted = true;

            gameObject.GetComponent<Renderer>().enabled = false;

            // Hide the powerup
        }
    }

    public IEnumerator RemoveSpeedBoost()
    {
        yield return new WaitForSeconds(powerupDuration);

        script.moveSpeed -= speedBoostAmount;

        Destroy(gameObject);
    }
}

