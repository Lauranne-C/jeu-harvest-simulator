using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveHeadL : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    float zRotation = -60f;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        float JoystickX = Input.GetAxis("Joystick X") * mouseSensitivity * Time.deltaTime;
        zRotation += JoystickX;
        zRotation = Mathf.Clamp(zRotation, -120f, -30f);

        transform.localRotation = Quaternion.Euler(0f, -90f, zRotation);
    }
}
