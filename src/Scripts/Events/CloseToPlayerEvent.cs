/// Marcos Barrios
/// Interfaces Inteligentes
///
/// Trigger event when the player is past a certain threshold distance from the
/// GameObject holding this script.
 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseToPlayerEvent : MonoBehaviour {

  public delegate void OnCloseEnough();
  public static event OnCloseEnough onCloseEnoughToPlayer;

  public int thresholdDistanceToPlayer = 2;

  private GameObject player;

  void Start() {
    player = GameObject.FindWithTag("Player");
  }

  void Update() {
    Vector3 vectorToPlayer = player.transform.position - gameObject.transform.position;
    float distanceToPlayer = vectorToPlayer.magnitude;
    if (distanceToPlayer <= thresholdDistanceToPlayer) {
      Debug.DrawRay(transform.position, vectorToPlayer, Color.blue, 0, false);
      onCloseEnoughToPlayer();
    }
  }
}
