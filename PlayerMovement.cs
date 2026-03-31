using UnityEngine;

/*
 * Handles player movement using Unity physics.
 * Uses Rigidbody instead of directly modifying position.
 */

[RequireComponent(typeof(Rigidbody))] //This makes the script require a rigidbody, as it will apply velocity explicitly to this.
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody rb;
    private PlayerInputHandler input;

    void Awake()
    {
        // Get components
        rb = GetComponent<Rigidbody>();
        input = GetComponent<PlayerInputHandler>();
    }

    void FixedUpdate()
    {
        Move();
    }

//"move" is a Unity call that comes built-in. A lot of coding in Unity is learning all the functions.
    void Move()
    {
        // Get movement direction relative to player orientation
        Vector3 moveDirection = transform.forward * input.moveZ +
                                transform.right * input.moveX;

        // Normalize so diagonal movement isn't faster
        moveDirection.Normalize();

        // Apply velocity while preserving vertical velocity (gravity)
        Vector3 velocity = moveDirection * moveSpeed;
        velocity.y = rb.linearVelocity.y;

        rb.linearVelocity = velocity;
    }
}