using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_arm_2 : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    float yRotation = -60f;
    float time = 0;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        time++;
        float JoystickY = Input.GetAxis("Joystick Y") * mouseSensitivity * Time.deltaTime;
        yRotation += JoystickY;
        yRotation = Mathf.Clamp(yRotation, -120f, -30f);


        transform.localRotation = Quaternion.Euler(0f, 0f, yRotation);
    }
}
