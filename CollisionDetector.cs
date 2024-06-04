using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
   private PlayerMovement playerMovement;

    void Start()
    {
        // Get the PlayerMovement component attached to the same GameObject
        playerMovement = GetComponent<PlayerMovement>();
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object has a tag that indicates it should stop the character
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Character collided with an obstacle!");
            // Stop the character's movement
            playerMovement.enabled = false;
        }
    }
      
}
    