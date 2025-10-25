using UnityEngine;

/// <summary>
/// A simple player controller script for basic movement.
/// Attach this to a player GameObject to enable keyboard-based movement.
/// </summary>
public class PlayerController : MonoBehaviour
{
    [Header("Movement Settings")]
    [Tooltip("Movement speed of the player")]
    public float moveSpeed = 5f;

    [Tooltip("Jump force applied to the player")]
    public float jumpForce = 7f;

    [Header("Ground Check")]
    [Tooltip("Is the player currently on the ground?")]
    public bool isGrounded = false;

    private Rigidbody rb;

    void Start()
    {
        // Get the Rigidbody component
        rb = GetComponent<Rigidbody>();
        
        if (rb == null)
        {
            Debug.LogWarning("PlayerController: No Rigidbody component found. Adding one.");
            rb = gameObject.AddComponent<Rigidbody>();
        }
    }

    void Update()
    {
        // Get input from WASD or Arrow keys
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Create movement vector
        Vector3 movement = new Vector3(horizontal, 0f, vertical);

        // Apply movement
        if (movement.magnitude > 0)
        {
            transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);
        }

        // Jump when space is pressed and player is grounded
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if player has landed on the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionStay(Collision collision)
    {
        // Ensure isGrounded stays true while on ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        // Player has left the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
