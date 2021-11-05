/// Marcos Barrios
/// Interfaces Inteligentes
///
/// Singleton script that defines all the events on the scene.
///
/// By definition events should only be called within the objects that defined
/// them. For example an Operator has an event with agents that need help as
/// subscribers. That operator will be the one to decide when to assist those
/// agents and not the other agents.
/// 
/// I could have the events on each object but in this case it makes more sense
/// for this scene controller to handle the events since they take place on
/// unrelated objets.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySceneController : MonoBehaviour {

  private static MySceneController gameController;
  
  public delegate void OnCollisionWithCylinder();
  public static event OnCollisionWithCylinder onColisionWithB;
  public static event OnCollisionWithCylinder onColisionWithA;
  public static event OnCollisionWithCylinder onCloseToA;

  /// To allow unrelated objects to call the event.
  public static void RaiseOnCollisionWithB() {
    if (onColisionWithB != null) {
      onColisionWithB();
    }
  }

  public static void RaiseOnCollisionWithA() {
    if (onColisionWithA != null) {
      onColisionWithA();
    }
  }

  public static void RaiseOnCloseToA() {
    if (onCloseToA != null) {
      onCloseToA();
    }
  }

  /// Singleton
  void Awake() {
    if (gameController == null) {
      gameController = this;
      DontDestroyOnLoad(this);
    } else if (gameController != this) {
      Destroy(gameObject);
    }
  }
}
