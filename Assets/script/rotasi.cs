using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class rotasi : MonoBehaviour
{
    public GameObject objectToRotate;
    public float rotationSpeed = 50f;

    private ARSessionOrigin arSessionOrigin;
    private bool rotateRight = false;
    private bool rotateLeft = false;

    void Start()
    {
        arSessionOrigin = FindObjectOfType<ARSessionOrigin>();
    }

    void Update()
    {
        if (rotateRight)
        {
            objectToRotate.transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
        else if (rotateLeft)
        {
            objectToRotate.transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }
    }

    public void RotateRightButtonDown()
    {
        rotateRight = true;
    }

    public void RotateRightButtonUp()
    {
        rotateRight = false;
    }

    public void RotateLeftButtonDown()
    {
        rotateLeft = true;
    }

    public void RotateLeftButtonUp()
    {
        rotateLeft = false;
    }
}

