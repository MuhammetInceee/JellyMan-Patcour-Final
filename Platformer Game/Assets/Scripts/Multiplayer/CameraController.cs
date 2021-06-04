using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;


    private Vector3 initialDistance;

    void Start()
    {
        initialDistance = target.position - transform.position;
    }

    void Update()
    {
        transform.position = target.position - initialDistance;
    }
}