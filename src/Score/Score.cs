/**
 * Marcos Barrios
 * Interfaces Inteligentes
 * 
 * Store a score and allow other scripts to increase it.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

  private int score = 0;

  public void increaseScore() {
    score++;
    Debug.Log("Score:" + score);
  } 
}
