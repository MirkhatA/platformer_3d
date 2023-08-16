using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    public Vector3 offset;

    public bool border;
    
    public float minX;
    public float maxX;

    public float minY;
    public float maxY;

    public float minZ;
    public float maxZ;

    void Start()
    {
        offset = target.position - transform.position;
    }

    void Update()
    {
        transform.position = target.position - offset;

        transform.LookAt(target);

        if (border) 
        {
            transform.position = new Vector3(
                Mathf.Clamp(transform.position.x, minX, maxX), 
                Mathf.Clamp(transform.position.y, minY, maxY), 
                Mathf.Clamp(transform.position.z, minZ, maxZ)
                );
        }
    }
}
