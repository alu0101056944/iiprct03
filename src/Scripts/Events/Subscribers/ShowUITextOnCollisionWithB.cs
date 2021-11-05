/// Marcos Barrios
/// Interfaces Inteligentes
///
/// Meant to be added to CylinderA GameObject instances.
/// Show UI text when a collision to B has occured. Uses C# events.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUITextOnCollisionWithB : MonoBehaviour {

  private bool drawGUI = false;

  void Awake() {
    MySceneController.onColisionWithB += renderTextOnGUI;
  }

  void OnDestroy() {
    MySceneController.onColisionWithB -= renderTextOnGUI;      
  }

  void OnGUI() {
    if (drawGUI) {
      GUI.Label(new Rect(Screen.width - 50, 0, 50, 20), "Colisión con B.");
    }
  }

  void renderTextOnGUI() {
    drawGUI = true;
  }
}
