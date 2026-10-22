using UnityEngine;
using UnityEngine.InputSystem; // Para el Input System de Unity 6

public class CambiarColor : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Detecta cuando se presiona CUALQUIER tecla del teclado
        if (Keyboard.current != null && Keyboard.current.anyKey.wasPressedThisFrame)
        {
            CambiarAColorAleatorio();
        }
    }

    void CambiarAColorAleatorio()
    {
        if (spriteRenderer != null)
        {
            spriteRenderer.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}