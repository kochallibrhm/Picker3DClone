using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform cam;
    public Transform picker;
    public Vector3 offset;

    void Start()
    {
        offset = transform.position - picker.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = picker.position + offset;
        transform.rotation = cam.rotation;
    }
}
