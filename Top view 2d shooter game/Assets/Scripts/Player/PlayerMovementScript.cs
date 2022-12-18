using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Responsible for basic player movement.
public class PlayerMovementScript : MonoBehaviour
{
    public float movementSpeed;             // Speed of the player.

    public Camera mainCamera;               // Main camera of the game
    private Rigidbody2D playerRigidbody;    // Rigidbody2D of the player
    private Vector2 playerVelocity;         // Velocity of the player
    public Transform cameraPosition;

    void Start() {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate() {
        float horizontalAxis = Input.GetAxis("Horizontal");
        float verticalAxis = Input.GetAxis("Vertical");

        // Up down, left right movement
        playerVelocity = new Vector2(horizontalAxis, verticalAxis) * movementSpeed;
        playerRigidbody.velocity = playerVelocity;

        // Causes the player to look at where the cursor is
        Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        Vector3 newRotation = mousePosition - transform.position;
        newRotation.z = 0f;
        transform.right = newRotation;

        Vector3 newCameraPosition = new Vector3(cameraPosition.position.x, cameraPosition.position.y, mainCamera.transform.position.z);
        mainCamera.transform.position = Vector3.Slerp(mainCamera.transform.position, newCameraPosition, 0.1F);
    }
}
