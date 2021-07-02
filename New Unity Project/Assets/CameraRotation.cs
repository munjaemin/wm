using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    float rx;
    float ry;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");
        rx += my * 1.5f;
        ry += mx * 1.5f;

        transform.eulerAngles = new Vector3(-rx, ry, 0);

        rx = Mathf.Clamp(rx, -80, 80);


    }
}
