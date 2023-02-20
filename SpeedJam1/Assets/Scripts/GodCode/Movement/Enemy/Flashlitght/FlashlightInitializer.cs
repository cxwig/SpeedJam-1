using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Flashlight))]
[RequireComponent(typeof(IGetterRotation))]
public class FlashlightInitializer : MonoBehaviour
{
    private Flashlight _flashlight;
    private IGetterRotation _getterRotation;
    private void Awake()
    {
        _getterRotation = GetComponent<IGetterRotation>();
        _flashlight = GetComponent<Flashlight>();
        Initialize();
    }
    private void Initialize()
    {
        _flashlight.Initialize(_getterRotation.GetRotation());
    }

}
