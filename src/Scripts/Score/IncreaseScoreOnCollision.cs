/**
 * Marcos Barrios
 * Interfaces Inteligentes
 * 
 * Increase the player's scope when a collision with the game object holding
 * this script takes place.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseScoreOnCollision : MonoBehaviour {

  private Score scoreHolder; 
  void Start() {
    scoreHolder = GameObject.FindWithTag("Player").GetComponent<Score>();
  }

  void OnCollisionEnter() {
    if (scoreHolder != null) {
      scoreHolder.increaseScore();
    } else {
      Debug.LogError("Can't find Score script on gameobject with tag 'Player'");
    }
  }
}
