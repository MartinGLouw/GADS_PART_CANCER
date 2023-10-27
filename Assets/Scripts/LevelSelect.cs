using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    // Start is called before the first frame update
    public void Level1()
    {
        // Load the next scene
        
        SceneManager.LoadScene("Lungs");
    }
    public void Level2()
    {
        // Load the next scene
        
        SceneManager.LoadScene("Testicles");
    }
    public void Back()
    {
        // Load the next scene
        
        SceneManager.LoadScene("MainMenu");
    }
    public void LVS()
    {
        // Load the next scene
        
        SceneManager.LoadScene("LevelSelect");
    }
}
