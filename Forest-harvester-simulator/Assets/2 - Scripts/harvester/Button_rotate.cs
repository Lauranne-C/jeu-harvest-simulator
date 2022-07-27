using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_rotate : MonoBehaviour
{
    public GameObject arm_controller;
    public GameObject arm_controller2;
    public GameObject arm_controller3;
    public GameObject cabin;
    public GameObject headL;
    public GameObject headR;
    // Start is called before the first frame update
    void Start()
    {
        arm_controller2.GetComponent<rotate_arm_2>().enabled = true;
        arm_controller.GetComponent<rotate_arm>().enabled = true;
        cabin.GetComponent<rotate_cabin>().enabled = false;
        headL.GetComponent<moveHeadL>().enabled = false;
        headR.GetComponent<moveHeadR>().enabled = false;
        arm_controller3.GetComponent<arm_rotate_3>().enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Joystick 2 button 2"))
        {
            arm_controller2.GetComponent<rotate_arm_2>().enabled = false;
            arm_controller.GetComponent<rotate_arm>().enabled = false;
            cabin.GetComponent<rotate_cabin>().enabled = true;
            headL.GetComponent < moveHeadL > ().enabled = false;
            headR.GetComponent<moveHeadR>().enabled = false;
            arm_controller3.GetComponent<arm_rotate_3>().enabled = false;
            
        }
        else if (Input.GetButton("Joystick 2 button 3"))
        {
            arm_controller2.GetComponent<rotate_arm_2>().enabled = true;
            arm_controller.GetComponent<rotate_arm>().enabled = true;
            cabin.GetComponent<rotate_cabin>().enabled = false;
            headL.GetComponent < moveHeadL > ().enabled = false;
            headR.GetComponent<moveHeadR>().enabled = false;
            arm_controller3.GetComponent<arm_rotate_3>().enabled = false;
           
        }
        else if (Input.GetButton("Joystick 2 button 4"))
        {
            arm_controller2.GetComponent<rotate_arm_2>().enabled = false;
            arm_controller.GetComponent<rotate_arm>().enabled = false;
            cabin.GetComponent<rotate_cabin>().enabled = false;
            headL.GetComponent<moveHeadL>().enabled = true;
            headR.GetComponent<moveHeadR>().enabled = true;
            arm_controller3.GetComponent<arm_rotate_3>().enabled = false;
           
        }
        else if (Input.GetButton("Joystick 2 button 5"))
        {
            arm_controller2.GetComponent<rotate_arm_2>().enabled = false;
            arm_controller.GetComponent<rotate_arm>().enabled = true;
            cabin.GetComponent<rotate_cabin>().enabled = false;
            headL.GetComponent<moveHeadL>().enabled = false;
            headR.GetComponent<moveHeadR>().enabled = false;
            arm_controller3.GetComponent<arm_rotate_3>().enabled = true;
            
        }
    }
}