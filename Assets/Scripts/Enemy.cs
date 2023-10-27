using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EndCanvasManager endCanvasManager; // Reference to the EndCanvasManager

    void OnDestroy()
    {
        // Check if endCanvasManager is not null before calling EnemyKilled
        if (endCanvasManager != null)
        {
            endCanvasManager.EnemyKilled();
        }
    }

}