using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangerTarget : MonoBehaviour
{
    [SerializeField] private PickedUpItem _pickedUpItem;
    [SerializeField] private _WindowPointer _windowPointer;
    [SerializeField] private Transform _startTarget;
    private void Start()
    {
        _pickedUpItem.OnPickUp += SetStartTarget;
        _windowPointer.Show(_pickedUpItem.transform.position);
    }
    private void SetStartTarget()
    {
        _windowPointer.Show(_startTarget.position);
    }
    private void OnDisable()
    {
        _pickedUpItem.OnPickUp -= SetStartTarget;
    }
}
