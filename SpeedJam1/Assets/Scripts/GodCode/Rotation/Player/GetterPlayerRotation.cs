using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterPlayerRotation : MonoBehaviour, IGetterRotation
{
    private IGetterMove _getterMove;
    private void Awake()
    {
        _getterMove = GetComponent<IGetterMove>();
    }
    public IRotation GetRotation()
    {
      return  new FlippingRotation(transform, new ReturnerRotationByMovement(_getterMove.GetMove().ReturnerVector, transform));
    }
}
