using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _SpeedBoostPowerUps : MonoBehaviour
{
    [SerializeField] private float speedBoostAmount = 1.5f;
    public float powerupDuration = 10f;
    [SerializeField] private AudioClip powerupSound;
    public _PlayerMovement script;

    private bool hasBoosted = false;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && !hasBoosted)
        {
            Debug.Log("powerup collected");

            AudioSource.PlayClipAtPoint(powerupSound, transform.position);

            script.moveSpeed += speedBoostAmount;


            StartCoroutine(RemoveSpeedBoost());


            hasBoosted = true;

            gameObject.GetComponent<Renderer>().enabled = false;
        }
    }

    public IEnumerator RemoveSpeedBoost()
    {
        yield return new WaitForSeconds(powerupDuration);

        script.moveSpeed -= speedBoostAmount;

        Destroy(gameObject);
    }
}

