using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public Canvas UICanvas;
    // Start is called before the first frame update
    void Start()
    {
        UICanvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Pause()
    {
        // Pause the game
        Time.timeScale = 0;
        UICanvas.enabled = true;
    }

    public void Resume()
    {
        // Resume the game
        Time.timeScale = 1;
        UICanvas.enabled = false;
    }
    public void LVS()
    {
        // Load the next scene
        Time.timeScale = 1;
        SceneManager.LoadScene("LevelSelect");
    }
}
