using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PickedUpItem : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _pickUpText;

    [SerializeField] private KeyCode _pickUpKey = KeyCode.F;
    private void Start()
    {
        Disactive();
    }

    private void Update()
    {
        if (_pickUpText.gameObject.activeInHierarchy && Input.GetKeyDown(_pickUpKey))
            PickUp();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.TriggerEntity<Player>((player) =>
        {
            Active();
        });
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.TriggerEntity<Player>((player) =>
        {
            Disactive();
        });
    }
    private void Disactive() => _pickUpText.gameObject.SetActive(false);
    private void Active() => _pickUpText.gameObject.SetActive(true);
    private void PickUp()
    {
        Destroy(gameObject);
    }

}
