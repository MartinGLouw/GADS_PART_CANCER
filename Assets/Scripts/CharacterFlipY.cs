using UnityEngine;

public class CharacterFlipY : MonoBehaviour
{
    public Camera customCamera;
    public Transform characterTransform;

    void Start()
    {
        if (customCamera == null)
        {
            customCamera = Camera.main;
        }
    }

    void Update()
    {
        FlipCharacter();
    }

    void FlipCharacter()
    {
        Vector3 mousePosition = customCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -customCamera.transform.position.z));
        Vector3 characterPosition = characterTransform.position;

        Vector3 localScale = characterTransform.localScale;

        if (mousePosition.x < characterPosition.x)
        {
            localScale.y = Mathf.Abs(localScale.y) * -1; // Flip on Y-axis when the mouse is on the left
        }
        else
        {
            localScale.y = Mathf.Abs(localScale.y); // Flip on Y-axis when the mouse is on the right
        }

        characterTransform.localScale = localScale;
    }
}