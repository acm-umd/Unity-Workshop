using UnityEngine;

/*
 * Handles camera rotation (mouse look).
 * Rotates:
 * - Player (left/right)
 * - Camera pivot (up/down)
 */

public class PlayerLook : MonoBehaviour
{
    public float mouseSensitivity = 100f; // Most sensitivity and time related calls use 'f.' This is calling frames or pixels
    //In this case, 100f is a multiplier of how many pixels per inch your cursor will travel when you move it. 

    public Transform playerBody; // Reference to player

    private float xRotation = 0f;

    private PlayerInputHandler input;

    void Start()
    {
        // Lock cursor to center of screen
        Cursor.lockState = CursorLockMode.Locked;

        // Find input handler on player
        input = playerBody.GetComponent<PlayerInputHandler>();
    }

    void Update()
    {
        Look();
    }

    void Look() //Another built-in Unity function
    {
        float mouseX = input.mouseX * mouseSensitivity * Time.deltaTime;
        float mouseY = input.mouseY * mouseSensitivity * Time.deltaTime;

        // Vertical rotation (up/down)
        xRotation -= mouseY;

        // Clamp so player can't flip camera
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        // Apply vertical rotation to camera pivot
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Rotate player left/right
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
