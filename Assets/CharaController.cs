using UnityEngine;
using UnityEngine.InputSystem; // <-- Agregar este namespace

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;

    void Update()
    {
        float moveX = 0f;
        float moveZ = 0f;

        // Leer teclado usando el nuevo Input System
        if (Keyboard.current != null)
        {
            if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed) moveZ = 1f;
            if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed) moveZ = -1f;
            if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed) moveX = -1f;
            if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed) moveX = 1f;
        }

        Vector3 movement = new Vector3(moveX, 0.0f, moveZ);

        transform.Translate(movement * speed * Time.deltaTime);
    }
}