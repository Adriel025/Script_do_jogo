using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FLIP_DIRE : MonoBehaviour
{
    JointMotor2D motor;
    public HingeJoint2D hinge;

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            JointMotor2D motor = hinge.motor;
            motor.motorSpeed = 10000f;
            hinge.motor = motor;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            JointMotor2D motor = hinge.motor;
            motor.motorSpeed = -10000f;
            hinge.motor = motor;
        }
    }
}
