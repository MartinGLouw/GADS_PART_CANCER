using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyManager : MonoBehaviour
{
    public List<string> quips; // List of quips to display
    public Canvas quipCanvas; // Canvas to display quips
    public TextMeshProUGUI quipText; // TextMeshProUGUI to display the quip
    public Canvas endCanvas; // Canvas to display at the end

    private int _enemyCount; // Total number of enemies in the scene
    private int _enemiesKilled = 0; // Number of enemies killed

    void Start()
    {
        // Initially disable the canvases
        quipCanvas.enabled = false;
        endCanvas.enabled = false;

        // Count the total number of enemies in the scene
        _enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        Debug.Log(_enemyCount + " enemies in the scene");
    }

    public void EnemyKilled()
    {
        _enemiesKilled++;
        Debug.Log(_enemiesKilled + " enemies killed");
        if (_enemiesKilled % 3 == 0)
        {
            ShowQuip();
        }

        if (_enemiesKilled == _enemyCount)
        {
            ShowEndCanvas();
        }
    }

    private void ShowQuip()
    {
        // Check if there are any quips left
        if (quips.Count > 0)
        {
            // Choose a random quip
            int index = Random.Range(0, quips.Count);
            string quip = quips[index];

            // Remove the chosen quip from the list
            quips.RemoveAt(index);

            // Enable the canvas and display the chosen quip
            quipCanvas.enabled = true;
            quipText.text = quip;
        }
    }


    private void ShowEndCanvas()
    {
        // Enable the end canvas and freeze game time
        endCanvas.enabled = true;
        Time.timeScale = 0f;
    }
    public void OnButtonClick()
    {
        // Load the next scene
        
        SceneManager.LoadScene("Testicles");
    }
}