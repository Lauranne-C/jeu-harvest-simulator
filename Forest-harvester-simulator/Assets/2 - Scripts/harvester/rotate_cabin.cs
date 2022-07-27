using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_cabin : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    float xRotation = -60f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float JoystickX = Input.GetAxis("Joystick X") * mouseSensitivity * Time.deltaTime;
        xRotation -= JoystickX;

        transform.localRotation = Quaternion.Euler(xRotation, 90f, 90f);
    }
}
