/// Marcos Barrios
/// Interfaces Inteligentes
///
/// Moves the cube back and forth on Z axis. Meant for demonstration of LookAt
/// Transform function.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCube : MonoBehaviour {

  private float delta = 0f;
  private int direction = 1;

  public float rangeOfMovement = 4f;
  public float velocity = 5f;

  private Vector3 originalPosition;

  void Start() {
    originalPosition = gameObject.transform.position;
  }

  void Update() {
    if (Mathf.Abs(delta) > rangeOfMovement) {
      direction = -direction;
    }
    transform.position = originalPosition + (Vector3.forward * delta);
    delta += direction * Time.deltaTime * velocity;
  }
}
