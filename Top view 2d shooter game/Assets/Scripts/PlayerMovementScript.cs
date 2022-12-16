using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public float movementSpeed;

    private Rigidbody2D playerRigidbody;
    private Vector2 playerVelocity;

    void Start() {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate() {
        float horizontalAxis = Input.GetAxis("Horizontal");
        float verticalAxis = Input.GetAxis("Vertical");

        playerVelocity = new Vector2(horizontalAxis, verticalAxis) * movementSpeed;

        playerRigidbody.velocity = playerVelocity;
    }
}
