using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class Car : MonoBehaviour
{
    // Input Action References
    public InputActionReference inSteering;
    public InputActionReference inThrottle;
    public InputActionReference inBrake;

    // Objects to create
    public Transform car;
    public Transform wheelObj;

    // Customizable Parameters
    public enum DriveType { RWD, FWD, AWD }
    public DriveType driveType;

    // Private
    private Transform _wheelFL;
    private Transform _wheelFR;
    private Transform _wheelRL;
    private Transform _wheelRR;


    // Start is called before the first frame update
    void Start()
    {
        float wheelWidthOffset = 1f;
        float wheelLengthOffset = 1.75f;
        float wheelHeightOffset = 0f;

        _wheelFL = Instantiate(wheelObj);
        _wheelFR = Instantiate(wheelObj);
        _wheelRL = Instantiate(wheelObj);
        _wheelRR = Instantiate(wheelObj);

        _wheelFL.SetParent(car, false);
        _wheelFR.SetParent(car, false);
        _wheelRL.SetParent(car, false);
        _wheelRR.SetParent(car, false);

        _wheelFL.Translate(new Vector3(wheelLengthOffset, wheelHeightOffset, wheelWidthOffset));
        _wheelFR.Translate(new Vector3(wheelLengthOffset, wheelHeightOffset, -wheelWidthOffset));
        _wheelRL.Translate(new Vector3(-wheelLengthOffset, wheelHeightOffset, wheelWidthOffset));
        _wheelRR.Translate(new Vector3(-wheelLengthOffset, wheelHeightOffset, -wheelWidthOffset));
    }

    void FixedUpdate()
    {
        Steer();
        Throttle();
        Brake();
    }

    void Steer()
    {
        float steering = inSteering.action.ReadValue<float>();
        steering *= 30f;
        _wheelFL.localRotation = Quaternion.Euler(0f, steering, 0f);
        _wheelFR.localRotation = Quaternion.Euler(0f, steering, 0f);
    }

    void Throttle()
    {
        float throttle = inThrottle.action.ReadValue<float>();
        throttle *= -40;

        if (driveType == DriveType.RWD)
        {
            _wheelRL.Rotate(0f, 0f, throttle);
            _wheelRR.Rotate(0f, 0f, throttle);
        }
        else if (driveType == DriveType.FWD)
        {
            // TODO: fix rotations
            _wheelFL.Rotate(0f, 0f, throttle);
            _wheelFR.Rotate(0f, 0f, throttle);
        }
        else
        {
            _wheelRL.Rotate(0f, 0f, throttle);
            _wheelRR.Rotate(0f, 0f, throttle);
            _wheelFL.Rotate(0f, 0f, throttle);
            _wheelFR.Rotate(0f, 0f, throttle);
        }
        
    }

    void Brake()
    {
        float brake = inBrake.action.ReadValue<float>();
        // TODO: implement
    }
}
