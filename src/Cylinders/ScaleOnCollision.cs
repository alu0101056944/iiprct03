/**
 * Marcos Barrios
 * Interfaces Inteligentes
 * 
 * Scale the GameObject's Transform when something collisions with it.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleOnCollision : MonoBehaviour {

  private CapsuleCollider capsuleCollider;
  public int scaleFactor = 1;
  void Start() {
    capsuleCollider = GetComponent<CapsuleCollider>();
  }

  void OnCollisionEnter() {
    transform.localScale += Vector3.one * Time.deltaTime * scaleFactor;
  }
}
