using UnityEngine;

public class ProjectileDamage : MonoBehaviour
{
    public int damage = 15;

    private void OnTriggerEnter(Collider other)
    {
        // Check for EnemyHealth component
        EnemyHealth enemyHealth = other.GetComponent<EnemyHealth>();
        if (enemyHealth != null)
        {
            enemyHealth.TakeDamage(damage);
            Destroy(gameObject); // Destroy the projectile after dealing damage
        }
    }
}
