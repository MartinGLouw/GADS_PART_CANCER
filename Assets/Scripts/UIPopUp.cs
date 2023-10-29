using UnityEngine;
using UnityEngine.UI;

public class UIPopUp : MonoBehaviour
{
    public Canvas gameCanvas; 
    public Button closeButton; 

    private bool hasCollided = false;

    private void Start()
    {
        
        gameCanvas.enabled = false;

        
        closeButton.onClick.AddListener(CloseCanvas);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Dialogue") && !hasCollided)
        {
            hasCollided = true;

            
            gameCanvas.enabled = true;
            Time.timeScale = 0f;
        }
    }

    private void CloseCanvas()
    {
        
        gameCanvas.enabled = false;
        Time.timeScale = 1f;
    }
    
}