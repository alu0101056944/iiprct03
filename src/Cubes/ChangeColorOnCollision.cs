/**
 * Marcos Barrios
 * Interfaces Inteligentes
 * 
 * Change color when something collides with this GameObject.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnCollision : MonoBehaviour {

  private Renderer thisRenderer;
  private Color originalColor;

  private bool hasCollided = false;
  private float timeSinceCollision;

  void Start() {
    thisRenderer = GetComponent<Renderer>();
    originalColor = thisRenderer.material.color;
  }

  void FixedUpdate() {
    if (hasCollided) {
      timeSinceCollision += Time.fixedDeltaTime;
    }
    if (timeSinceCollision > 0.1) {
      timeSinceCollision = 0;
      thisRenderer.material.color = originalColor;
      hasCollided = false;
    }
  }

  void OnCollisionEnter() {
    thisRenderer.material.color = new Color(0.3f, 0.3f, 0.1f);
    hasCollided = true;
  }
}
