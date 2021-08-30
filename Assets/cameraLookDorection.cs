using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraLookDorection : MonoBehaviour
{

    private float rotateYSpeed = 1.0f;


     void Update()
    {
        float mouseY = Input.GetAxis("Mouse Y");
        transform.Rotate(new Vector3(   -mouseY, 0, 0));
        //transform.localEulerAngles = new Vector3((transform.localEulerAngles.x + mouseY)
        //    * rotateYSpeed, transform.localEulerAngles.y, transform.localEulerAngles.z);
    }
}
