using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    
    private Transform lookAt;
    private Vector3 startOffset;

    void Start ()
    {
        lookAt = GameObject.FindGameObjectWithTag("Player").transform;
        startOffset = transform.position - lookAt.position;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = lookAt.position + startOffset;
    }
}
