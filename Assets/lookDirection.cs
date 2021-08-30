using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookDirection : MonoBehaviour
{

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(new Vector3(0, mouseX, 0));
        //transform.localEulerAngles = new Vector3((transform.localEulerAngles.x+ mouseX)*
        //    transform.localEulerAngles.y, transform.localEulerAngles.z);

    }

}
