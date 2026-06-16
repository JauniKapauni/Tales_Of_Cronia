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
        if (Keyboard.current.aKey.wasPressedThisFrame){
            transform.rotation = Quaternion.Euler(0f, -180f, 0f);
        }
        if (Keyboard.current.dKey.isPressed)
            movement.x += 1;
        if (Keyboard.current.dKey.wasPressedThisFrame){
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        transform.position += (Vector3)(movement * speed * Time.deltaTime);
    }
}