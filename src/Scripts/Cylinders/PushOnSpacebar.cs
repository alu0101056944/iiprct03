/**
 * Marcos Barrios
 * Interfaces Inteligentes
 * 
 * Push the gameobject away from the player when he presses spacebar.
 * 
 * Kinematic state is used to stop the player from moving the object during
 * collision.
 * 
 * Push strength is modified when player collides with any cylinder of type A.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushOnSpacebar : MonoBehaviour {

  public float pushStrength = 200f;
  public float pushStrengthIncrease = 200f;

  private Transform playerTransform;
  private Rigidbody rigidBody;

  private bool wasKinematic;
  private bool spacePressed = false;

  void Awake() {
    MySceneController.onColisionWithA += increasePushStrength;
  }

  void Start() {
    playerTransform = GameObject.FindWithTag("Player").transform;
    rigidBody = GetComponent<Rigidbody>();
    wasKinematic = rigidBody.isKinematic;
  }

  // Push away from the player
  void FixedUpdate() {
    if (spacePressed) {
      rigidBody.isKinematic = false;
      Vector3 pushVector = transform.position - playerTransform.position;
      Vector3 pushDirection = Vector3.Normalize(pushVector);
      rigidBody.AddForce(pushDirection * pushStrength);
      spacePressed = false;
    }
  }

  /// To keep it kinematic unless it has been pushed.
  void Update() {
    if (Input.GetKeyDown("space")) {
      spacePressed = true;
    }
    float velocityX = Mathf.Abs(rigidBody.velocity.x);
    float velocityZ = Mathf.Abs(rigidBody.velocity.z);
    if (velocityX < 0.5 && velocityZ < 0.5) { // nearly stopped
      rigidBody.isKinematic = true;
    }
  }

  void OnDestroy() {
    MySceneController.onColisionWithB -= increasePushStrength;
  }

  void increasePushStrength() {
    pushStrength += pushStrengthIncrease;
  }
}
