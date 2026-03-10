using UnityEngine;
using UnityEngine.InputSystem;

public class magnuseffectkick : MonoBehaviour
{
    public float kickForce;
    public float spinAmount;
    public float magnusStrenght = 0.5f;

    Rigidbody rb;
    bool ishot = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Press space to kick the ball
        if (Keyboard.current.spaceKey.wasPressedThisFrame && !ishot)
        {
            rb.AddForce(Vector3.forward * kickForce, ForceMode.Impulse);

            // Add spin around Y axis
            rb.AddTorque(Vector3.up * spinAmount);

            ishot = true;
        }
    }

     void FixedUpdate()
    {
        if (!ishot) return;
        {
            Vector3 velocity = rb.linearVelocity; 
            Vector3 spin = rb.angularVelocity;
            
            //Magnus force calculation
            Vector3 magnusForce = magnusStrenght * Vector3.Cross(spin, velocity);

            rb.AddForce(magnusForce);
        }
    }
}
