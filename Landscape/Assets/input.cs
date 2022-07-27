using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class input : MonoBehaviour
{
    // Prints a joystick name if movement is detected.

    void Update()
    {
        if (Mathf.Abs(Input.GetAxis("Test")) > 0.2)
            {
                Debug.Log(" is moved");
            }
        
    }
}