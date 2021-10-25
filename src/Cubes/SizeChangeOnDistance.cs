/**
 * Marcos Barrios
 * Interfaces Inteligentes
 * 
 * Scale the GameObject to be smaller when the player is near and bigger when a
 * sphere is near. Player gets priority.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeChangeOnDistance : MonoBehaviour {

  public float thresholdDistance = 5;
  public float scaleFactor = 1;
  public float maximumScale = 3;
  public float minimumScale = 0.4f;

  public GameObject sphereObject;

  private Transform playerTransform;

  void Start() {
    playerTransform = GameObject.FindWithTag("Player").transform;
  }

  void FixedUpdate() {
    bool notTooSmall = transform.localScale.magnitude > minimumScale;
    bool notTooBig = transform.localScale.magnitude < maximumScale;

    float distanceToPlayer = Vector3.Distance(playerTransform.position, transform.position);
    float distanceToSphere = Vector3.Distance(sphereObject.transform.position, transform.position);
    if (distanceToPlayer < thresholdDistance && notTooSmall) {
      transform.localScale -= Vector3.one * Time.deltaTime * scaleFactor;
    } else if(distanceToSphere < thresholdDistance && notTooBig) {
      transform.localScale += Vector3.one * Time.deltaTime * scaleFactor;
    }
  }

}
