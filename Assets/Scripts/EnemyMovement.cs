using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject player;
    public float speed = 3.0f;
    public float detectionRange = 10.0f;

    private void Update()
    {
        // Calculate the distance between the enemy and the player
        float distanceToPlayer = Vector2.Distance(new Vector2(transform.position.x, transform.position.y), new Vector2(player.transform.position.x, player.transform.position.y));

        // If the player is within the detection range, move the enemy towards the player
        if (distanceToPlayer <= detectionRange)
        {
            Vector2 direction = (new Vector2(player.transform.position.x, player.transform.position.y) - new Vector2(transform.position.x, transform.position.y)).normalized;
            transform.position += new Vector3(direction.x, direction.y, 0) * speed * Time.deltaTime;
        }
    }
}