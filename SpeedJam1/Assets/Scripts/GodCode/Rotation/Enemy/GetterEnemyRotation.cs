using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterEnemyRotation : MonoBehaviour, IGetterRotation
{
    [SerializeField] private GetterEnemyMove _getterEnemyMove;
    private IRotation _rotation;
    private float _startX;
    [field:SerializeField] public FlashlightTrigger Flashlight { get; private set; }
    public Transform CurrentPoint { get; set; }
    private void Awake()
    {
        _startX = transform.localScale.x;
    }
    public IRotation GetRotation()
    {
        Debug.Log(" HAHAHAJOJO! 2222 " + CurrentPoint.name);
          return new FlippingRotation(transform, new ReturnerEnemyRotation(transform, _startX, CurrentPoint));
    }


}
