using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : EnemyManager
{
    public int maxHealth = 100;
    private int currentHealth;
    public TextMeshProUGUI healthText;

    // Define a delegate and event for when the enemy is destroyed
    public delegate void EnemyDestroyedAction();
    public static event EnemyDestroyedAction OnEnemyDestroyed;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthText();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateHealthText();

        if (currentHealth <= 0)
        {
            DestroyEnemy();
        }
    }

    private void DestroyEnemy()
    {
        // Invoke the OnEnemyDestroyed event before destroying the enemy
        if (OnEnemyDestroyed != null)
        {
            OnEnemyDestroyed.Invoke();
        }

        // Call EnemyKilled method from EnemyManager
        FindObjectOfType<EnemyManager>().EnemyKilled();

        // Handle enemy death (e.g., play an animation or sound effect before destroying the enemy)
        Destroy(gameObject);
    }


    private void UpdateHealthText()
    {
        if (healthText != null)
        {
            healthText.text = "Health: " + currentHealth;
        }
    }
}