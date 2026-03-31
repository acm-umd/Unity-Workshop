using UnityEngine;

/*
 * This script collects all player input.
 * Other scripts will "ask" this script for input values.
 * This makes your system modular and easy to expand.
 */

public class PlayerInputHandler : MonoBehaviour
{
    // Movement input (WASD / Arrow keys)
    public float moveX; // Left/Right
    public float moveZ; // Forward/Backward

    // Mouse input
    public float mouseX;
    public float mouseY;

    void Update()
    {
        // Get movement input
        moveX = Input.GetAxis("Horizontal"); // A/D or Left/Right
        moveZ = Input.GetAxis("Vertical");   // W/S or Up/Down

        // Get mouse input
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");
    }
}