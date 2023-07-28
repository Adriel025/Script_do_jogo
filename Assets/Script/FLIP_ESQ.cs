using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FLIP_ESQ: MonoBehaviour
{
    JointMotor2D motor;
    public HingeJoint2D hinge;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            JointMotor2D motor = hinge.motor;
            motor.motorSpeed = -10000f;
            hinge.motor = motor;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            JointMotor2D motor = hinge.motor;
            motor.motorSpeed = 10000f;
            hinge.motor = motor;
        }
    }
}
