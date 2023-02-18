using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _CameraMovement : MonoBehaviour
{
    public Transform target; // player
    [SerializeField] private float damping; // speed
    [SerializeField] private Vector3 offset; // offset for z

    private Vector3 velocity = Vector3.zero;

    void FixedUpdate()
    {
        Vector3 movePosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, movePosition, ref velocity, damping);
    }
}