using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon_Camera : MonoBehaviour
{
    public float sensitivity = 5.0f;

    void Update()
    {

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        transform.eulerAngles += new Vector3(-mouseY * sensitivity, mouseX * sensitivity,0);
    }
}