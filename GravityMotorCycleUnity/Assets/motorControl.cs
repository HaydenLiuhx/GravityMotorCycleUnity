using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motorControl : MonoBehaviour
{
    public WheelJoint2D front;
    public WheelJoint2D back;
   [SerializeField] float speed = 1500f;
    [SerializeField] float rotate = 1500f;
    JointMotor2D motor;
    Rigidbody2D rg;
    // Start is called before the first frame update
    void Start()
    {
        motor.maxMotorTorque = 10000;
        rg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        motor.motorSpeed = -speed * Input.GetAxis("Vertical");
        rg.AddTorque(rotate * Input.GetAxis("Horizontal")*Time.deltaTime);

        front.motor = motor;
        back.motor = motor;
    }

}
