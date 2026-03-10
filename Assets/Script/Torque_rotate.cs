using UnityEngine;
using UnityEngine.InputSystem;

public class Torque_rotate : MonoBehaviour
{
    public float torque;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Keyboard.current.dKey.isPressed)
        {
            rb.AddTorque(new Vector3(0, 0, torque));
        }
        else
        {
            rb.angularVelocity = Vector3.zero;
        }



    }
}
