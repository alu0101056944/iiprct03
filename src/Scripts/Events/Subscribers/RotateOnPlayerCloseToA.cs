/// Marcos Barrios
/// Interfaces Inteligentes
///
/// Rotate the sphere to face the player when it's close enough to it.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnPlayerCloseToA : MonoBehaviour {

  public GameObject objectToLookAt;

  void Awake() {
    CloseToPlayerEvent.onCloseEnoughToPlayer += faceToPlayer;
  }

  void OnDestroy() {
    CloseToPlayerEvent.onCloseEnoughToPlayer -= faceToPlayer;
  }
  
  private void faceToPlayer() {
    gameObject.transform.LookAt(objectToLookAt.transform);
  }

}
