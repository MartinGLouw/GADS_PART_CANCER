using UnityEngine;

public class FloatingMovement : MonoBehaviour
{
    public float force = 10.0f;
    public float drag = 1.0f;
    public float maxSpeed = 10.0f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 inputForce = new Vector3(horizontalInput, verticalInput, 0) * force;
        rb.AddForce(inputForce);

        // Clamp the character's velocity to the maxSpeed
        Vector3 clampedVelocity = Vector3.ClampMagnitude(new Vector3(rb.velocity.x, rb.velocity.y, 0), maxSpeed);
        rb.velocity = new Vector3(clampedVelocity.x, clampedVelocity.y, rb.velocity.z);

        if (Mathf.Approximately(horizontalInput, 0) && Mathf.Approximately(verticalInput, 0))
        {
            rb.velocity = Vector3.Lerp(rb.velocity, new Vector3(0, 0, rb.velocity.z), drag * Time.deltaTime);
        }
    }
}
