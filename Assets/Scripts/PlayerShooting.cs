using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float shootForce = 50.0f;
    public Camera mainCamera;

    void Start()
    {
        if (mainCamera == null)
        {
            mainCamera = Camera.main;
        }
    }

    void Update()
    {
        
        
        if (Input.GetMouseButtonDown(0))
        {
            ShootProjectile();
        }
        
    }

    void ShootProjectile()
    {
        // Get the mouse position in world space
        Vector3 mousePosition = mainCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -mainCamera.transform.position.z));

        // Calculate the direction from the player to the mouse pointer
        Vector3 direction = (new Vector3(mousePosition.x, mousePosition.y, transform.position.z) - transform.position).normalized;

        // Create the projectile and position it at the player's location
        GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);

        // Rotate the projectile to face the direction of the shot
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        projectile.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        // Get the projectile's Rigidbody component
        Rigidbody rb = projectile.GetComponent<Rigidbody>();

        // Apply force to the projectile in the direction of the mouse pointer
        rb.AddForce(direction * shootForce, ForceMode.Impulse);
    }


}