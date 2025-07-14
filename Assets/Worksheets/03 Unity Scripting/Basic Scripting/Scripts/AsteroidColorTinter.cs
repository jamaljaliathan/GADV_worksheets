using UnityEngine;

public class AsteroidColourTinter : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Color originalColor;
    private bool isBlue = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalColor = spriteRenderer.color;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isBlue)
            {
                spriteRenderer.color = originalColor;
            }
            else
            {
                spriteRenderer.color = Color.blue;
            }

            isBlue = !isBlue;
        }
    }
}