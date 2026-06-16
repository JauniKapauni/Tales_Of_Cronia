using UnityEngine;
using UnityEngine.InputSystem;

public class MovementScript : MonoBehaviour
{
    float speed = 5f;

    void Update()
    {
        Vector2 movement = Vector2.zero;

        if (Keyboard.current.wKey.isPressed)
            movement.y += 1;

        if (Keyboard.current.sKey.isPressed)
            movement.y -= 1;

        if (Keyboard.current.aKey.isPressed)
            movement.x -= 1;

        if (Keyboard.current.dKey.isPressed)
            movement.x += 1;

        transform.position += (Vector3)(movement * speed * Time.deltaTime);
    }
}