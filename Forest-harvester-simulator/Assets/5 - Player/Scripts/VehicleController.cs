using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;

public class VehicleController : MonoBehaviour
{
    public List<AxleInfo> axleInfos; // the information about each individual axle
    public float maxMotorTorque; // maximum torque the motor can apply to wheel
    public float maxSteeringAngle; // maximum steer angle the wheel can have

    public float PedalSensibility;
    public Rigidbody rb;
    float time = 0;
    private bool reverse_gear = false;

    public void FixedUpdate()
    {
        float motor = maxMotorTorque * Input.GetAxis("Vertical");
        float steering = maxSteeringAngle * Input.GetAxis("Horizontal");

        rb = GetComponent<Rigidbody>();
        bool isbrake = false;


        time++;
        if (time == 60) //just to see values of pedals output
        {
            //UnityEngine.Debug.Log(Input.GetAxis("Vertical"));
            UnityEngine.Debug.Log(Input.GetAxis("Jump"));
            time = 0;
        }
        foreach (AxleInfo axleInfo in axleInfos)
        {
            if (axleInfo.steering)
            {
                axleInfo.leftWheel.steerAngle = steering;
                axleInfo.rightWheel.steerAngle = steering;
            }
            if (axleInfo.motor)
            {
                axleInfo.leftWheel.motorTorque = motor;
                axleInfo.rightWheel.motorTorque = motor;
            }

            if (Input.GetAxis("Vertical") < -0.1) //check if we brake
            {
                isbrake = true;
            }
            else
            {
                isbrake = false;
                if (Input.GetAxis("Jump") == 1)
                {
                    reverse_gear = !reverse_gear;
                }
            }

            if (reverse_gear == true) { //code to go back with speed pedal
                axleInfo.leftWheel.motorTorque = -motor * 0.2F; //reverse motor and decreases speed
                axleInfo.rightWheel.motorTorque = -motor * 0.2F;
            }

            if (isbrake == true)
            {
                rb.drag += PedalSensibility * -(Input.GetAxis("Vertical")); //increases friction
                axleInfo.leftWheel.motorTorque = 0;
                axleInfo.rightWheel.motorTorque = 0;
                if (rb.drag > 6F)
                {
                    rb.drag = 45F;
                }
            }
            else
            {
                rb.drag = 0.15F;
            }
          
        }
    }
}

[System.Serializable]
public class AxleInfo
{
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public bool motor; // is this wheel attached to motor?
    public bool steering; // does this wheel apply steer angle?
}