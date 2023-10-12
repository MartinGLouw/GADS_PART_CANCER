using System.Collections;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage = 10;
    public float damageInterval = 2f; // Time in seconds between damage applications
    private PlayerHealth playerHealth;
    private bool isDealingDamage = false;

    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            playerHealth = player.GetComponent<PlayerHealth>();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && playerHealth != null && !isDealingDamage)
        {
            isDealingDamage = true;
            StartCoroutine(DealDamage());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isDealingDamage = false;
            StopCoroutine(DealDamage());
        }
    }

    private IEnumerator DealDamage()
    {
        while (isDealingDamage)
        {
            playerHealth.TakeDamage(damage);
            yield return new WaitForSeconds(damageInterval);
        }
    }
}
