using UnityEngine;
using UnityEngine.SceneManagement;

public class EndCanvasManager : MonoBehaviour
{
    public Canvas endCanvas; // Canvas to display at the end
    public int totalEnemies; // Total number of enemies in the scene

    private int _enemiesKilled = 0; // Number of enemies killed

    void Start()
    {
        // Initially disable the canvas
        DisableEndCanvas();
    }

    public void EnemyKilled()
    {
        _enemiesKilled++;
        if (_enemiesKilled == totalEnemies)
        {
            EnableEndCanvas();
        }
    }

    private void DisableEndCanvas()
    {
        endCanvas.enabled = false;
    }

    private void EnableEndCanvas()
    {
        endCanvas.enabled = true;
        Time.timeScale = 0f;
    }
    public void BackToLS()
    {
        // Load the next scene
        Time.timeScale = 1f;
        SceneManager.LoadScene("LevelSelect");
    }
}