/// Marcos Barrios
/// Interfaces Inteligentes
///
/// Change color when the event close enough to player has been triggered.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnPlayerCloseToA : MonoBehaviour {
  
  private Renderer myRenderer;

  void Awake() {
    CloseToPlayerEvent.onCloseEnoughToPlayer += changeColor;
  }

  void Start() {
    myRenderer = GetComponent<Renderer>();    
  }

  void OnDestroy() {
    CloseToPlayerEvent.onCloseEnoughToPlayer -= changeColor;
  }

  private void changeColor() {
    myRenderer.material.color = new Color(0.3f, 0, 0.5f);
  }
}
