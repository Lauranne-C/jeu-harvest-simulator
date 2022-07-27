using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationHead : MonoBehaviour
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
        float JoystickX = Input.GetAxis("Joystick Y") * mouseSensitivity * Time.deltaTime;
        xRotation += JoystickX;
        transform.localRotation = Quaternion.Euler(0f, xRotation, -60f);
    }
}