using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arm_rotate_3 : MonoBehaviour
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
        float JoystickX = Input.GetAxis("Joystick Y") * mouseSensitivity * Time.deltaTime;
        zRotation += JoystickX;
        zRotation = Mathf.Clamp(zRotation, -90f, -30f);

        transform.localRotation = Quaternion.Euler(0f, 0f, zRotation);
    }
}
