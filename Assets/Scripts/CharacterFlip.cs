using UnityEngine;

public class CharacterFlip : MonoBehaviour
{
    public Camera customCamera;
    public SpriteRenderer characterSpriteRenderer;

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
        Vector3 characterPosition = characterSpriteRenderer.transform.position;

        if (mousePosition.x < characterPosition.x)
        {
            characterSpriteRenderer.flipX = true; // Face left
        }
        else
        {
            characterSpriteRenderer.flipX = false; // Face right
        }
    }
}