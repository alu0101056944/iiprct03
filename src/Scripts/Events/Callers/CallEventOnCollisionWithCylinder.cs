/// Marcos Barrios
/// Interfaces Inteligentes
///
/// Call events of collision with A and B.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallEventOnCollisionWithCylinder : MonoBehaviour {
  
  void OnCollisionEnter(Collision c) {
    if (c.gameObject.tag == "CylinderA") {
      MySceneController.RaiseOnCollisionWithA();
    } else if (c.gameObject.tag == "CylinderB") {
      MySceneController.RaiseOnCollisionWithB();
    }
  }
}
