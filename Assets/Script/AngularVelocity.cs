using UnityEngine;
using UnityEngine.InputSystem;

public class AngularVelocity : MonoBehaviour
{
    public float angularspeed;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }
            
    
    private void FixedUpdate()
    {
        //Press 'A' to ratate using Angular Velocity
        if (Keyboard.current.aKey.isPressed)
        {
            rb.angularVelocity = new Vector3(0, angularspeed, 0);
        }
        else
        {
            rb.angularVelocity = Vector3.zero;
        }

    }
}




