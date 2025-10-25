using UnityEngine;

/// <summary>
/// A simple example script that demonstrates basic Unity scripting.
/// This script rotates the GameObject it's attached to.
/// </summary>
public class RotateObject : MonoBehaviour
{
    [Header("Rotation Settings")]
    [Tooltip("Speed of rotation in degrees per second")]
    public float rotationSpeed = 50f;

    [Tooltip("Axis around which the object rotates")]
    public Vector3 rotationAxis = Vector3.up;

    // Update is called once per frame
    void Update()
    {
        // Rotate the object around the specified axis at the specified speed
        transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime);
    }
}
