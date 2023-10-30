using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
   

    public Canvas HowTOPlay;
    
    public Canvas Credits;

    public Canvas Options;
    // Start is called before the first frame update
    void Start()
    {
        
        
        
    }
    public void Level1()
    {
        // Load the next scene
        Time.timeScale = 1;
        SceneManager.LoadScene("Lungs");
    }
    public void Level2()
    {
        // Load the next scene
        Time.timeScale = 1;
        SceneManager.LoadScene("Testicles");
    }
    public void Back()
    {
        // Load the next scene
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
    public void LVS()
    {
        // Load the next scene
        Time.timeScale = 1;
        SceneManager.LoadScene("LevelSelect");
    }
    
    public void HowToPlay()
    {
        // Show How to Play screen
        HowTOPlay.gameObject.SetActive(true);
    }

    public void CreditsScreen()
    {
        // Show Credits screen
        Credits.gameObject.SetActive(true);
    }

    public void OptionsScreen()
    {
        // Show Options screen
        Options.gameObject.SetActive(true);
    }

    public void BackToPause()
    {
        // Hide all screens and show pause menu
        HowTOPlay.gameObject.SetActive(false);
        Credits.gameObject.SetActive(false);
        Options.gameObject.SetActive(false);
    }

    public void quit()
    {
        
        Application.Quit();
    }

    

}
