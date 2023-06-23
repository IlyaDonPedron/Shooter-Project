using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{



    public float mouseSensivity = 100f;
    public Transform playerBody;
    void Update()
    {
        float mouseX = Input.GetAxis("MouseX") * mouseSensivity*Time.deltaTime;
        float mouseY = Input.GetAxis("MouseY") * mouseSensivity * Time.deltaTime;

    }
}
