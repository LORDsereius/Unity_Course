using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform SphereTransform;
    public Vector3 offset;
    Vector3 currentPosition;
    void Update()
    {
        currentPosition = SphereTransform.position;
        this.gameObject.transform.position = currentPosition + offset;
        this.gameObject.transform.LookAt(SphereTransform);
    }
}
