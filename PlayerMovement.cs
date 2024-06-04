using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of the character

    void Update()
    {
        // Get input from arrow keys or WASD
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        // Create a vector for movement
        Vector3 move = new Vector3(moveX, 0, moveZ) * moveSpeed * Time.deltaTime;

        // Apply movement to the character
        transform.Translate(move, Space.World);

        // Rotate the character to face the movement direction
        if (move != Vector3.zero)
        {
            transform.forward = move;
        }
    }
}
