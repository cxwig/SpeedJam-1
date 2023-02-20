using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField] private SetterSneakingMove _sneakingMove;
    private bool _isEntered;
    private PlayerInitializer _player;
    [SerializeField] private float _radius = 4;
    [SerializeField] private BoxCollider2D _boxCollider2D;
    private void OnTriggerStay2D(Collider2D other)
    {
        other.TriggerEntity<PlayerInitializer>((player) =>
        {
            if (_sneakingMove.IsSneaking && _isEntered == false)
            {
                _player = player;
                Debug.Log("HOORAY!!");
                _isEntered = true;
                _boxCollider2D.enabled = false;
                //player.GetterMove.Move.ReturnerVector.ReturnerSpeed.Remove(player.GetterMove.ReturnerCurrentSpeed);
            }
        });
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        other.TriggerEntity<PlayerInitializer>((player) =>
        {
            if (_isEntered)
            {
               // player.GetterMove.Move.ReturnerVector.ReturnerSpeed.Add(player.GetterMove.ReturnerCurrentSpeed);
                _isEntered = false;
                _boxCollider2D.enabled = true;
                _player = null;
            }
        });
    }
}