using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public Camera cam;
    public float defaultFov = 40;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
            {
                cam.fieldOfView = (defaultFov / 2);
            }

        else
            {
                cam.fieldOfView = (defaultFov);
            } 
        
    }
}
