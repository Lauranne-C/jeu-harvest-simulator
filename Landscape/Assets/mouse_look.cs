using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_look : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    float xRotation = 0f;
    float yRotation = 0f;
    float time = 0;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time++;
        float JoystickX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float JoystickY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        xRotation -= JoystickY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        yRotation -= JoystickX;
        yRotation = Mathf.Clamp(yRotation, -70f, 70f);

        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
        if (time == 60)
        {
            Debug.Log(Input.GetAxis("Mouse X"));
            Debug.Log(Input.GetAxis("Mouse Y"));
            time = 0;
        }
        
    }
}
