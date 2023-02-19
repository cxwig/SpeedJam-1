using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        other.TriggerEntity<PlayerInitializer>((player) =>
        {
            player.GetterMove.Move.ReturnerVector.ReturnerSpeed.Remove(player.GetterMove.ReturnerCurrentSpeed);
        });
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        other.TriggerEntity<PlayerInitializer>((player) =>
        {
            player.GetterMove.Move.ReturnerVector.ReturnerSpeed.Add(player.GetterMove.ReturnerCurrentSpeed);
        });
    }
}