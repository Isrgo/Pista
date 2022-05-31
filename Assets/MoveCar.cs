using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{

    public float MotorForce, SteerForce, BrakeForce;
    public WheelCollider FrontLeftWheel, FrontRightWheel, RearLeftWheel, RearRightWheel;

   // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical") * MotorForce;
        float h = Input.GetAxis("Horizontal") * SteerForce;

        RearLeftWheel.motorTorque = v;
        RearRightWheel.motorTorque = v;

        FrontLeftWheel.steerAngle = h;
        FrontRightWheel.steerAngle = h;

        if(Input.GetKey(KeyCode.Space))
        {
            RearLeftWheel.brakeTorque = BrakeForce;
            RearRightWheel.brakeTorque = BrakeForce;
        }

          if(Input.GetKeyDown(KeyCode.Space))
        {
            RearLeftWheel.brakeTorque = 0;
            RearRightWheel.brakeTorque = 0;
        }

          if(Input.GetAxis("Vertical") == 0)
        {
            RearLeftWheel.brakeTorque = BrakeForce;
            RearRightWheel.brakeTorque = BrakeForce;
        }else
        {
            RearLeftWheel.brakeTorque = 0;
            RearLeftWheel.brakeTorque = 0;
        }

    }
}
