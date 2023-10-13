using UnityEngine;

public class LegRotation : MonoBehaviour
{
    public Rigidbody characterRigidbody;
    public Transform pivotPoint;
    public float distanceFromPivot = 1.0f;
    public float minRotationLimit = -180f; // Set your minimum rotation limit here
    public float maxRotationLimit = 0f; // Set your maximum rotation limit here

    void Start()
    {
        if (pivotPoint == null)
        {
            pivotPoint = transform;
        }
    }

    void Update()
    {
        RotateLeg();
    }

    void RotateLeg()
    {
        Vector2 movementDirection = characterRigidbody.velocity.normalized;
        float angle;

        // Check if the character's velocity is approximately zero
        if (characterRigidbody.velocity.sqrMagnitude < 0.01f)
        {
            // If there's no movement, set the angle to the resting position (bottom)
            angle = minRotationLimit + 90;
        }
        else
        {
            angle = Mathf.Atan2(-movementDirection.y, -movementDirection.x) * Mathf.Rad2Deg;
            angle = Mathf.Clamp(angle, minRotationLimit, maxRotationLimit); // Apply rotation limits
        }

        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        transform.rotation = rotation * Quaternion.Euler(0, 0, 90); // Add the initial 90-degree rotation
        transform.position = pivotPoint.position + (rotation * Vector3.right * distanceFromPivot);
    }
}