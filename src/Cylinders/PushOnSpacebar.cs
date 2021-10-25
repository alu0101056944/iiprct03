/**
 * Marcos Barrios
 * Interfaces Inteligentes
 * 
 * Push the gameobject away from the player when he presses spacebar.
 * 
 * Kinematic state is used to stop the player from moving the object during
 * collision.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushOnSpacebar : MonoBehaviour {

  public float pushStrength = 200f;

  private Transform playerTransform;
  private Rigidbody rigidBody;

  private bool wasKinematic;
  private bool hasToPush = false;

  void Start() {
    playerTransform = GameObject.FindWithTag("Player").transform;
    rigidBody = GetComponent<Rigidbody>();
    wasKinematic = rigidBody.isKinematic;
  }

  void FixedUpdate() {
    if (hasToPush) {
      rigidBody.isKinematic = false;
      Vector3 pushVector = transform.position - playerTransform.position;
      Vector3 pushDirection = Vector3.Normalize(pushVector);
      rigidBody.AddForce(pushDirection * pushStrength);
      hasToPush = false;
    }
  }
  void Update() {
    if (Input.GetKeyDown("space")) {
      hasToPush = true;
    }
    float velocityX = Mathf.Abs(rigidBody.velocity.x);
    float velocityZ = Mathf.Abs(rigidBody.velocity.z);
    if (velocityX < 0.5 && velocityZ < 0.5) {
      rigidBody.isKinematic = true;
    }
  }
}
