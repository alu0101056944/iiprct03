/**
 * Marcos Barrios
 * Interfaces Inteligentes
 * Move the game object using the wsad and/or arrows and rotate on OY axis using
 * the mouse. Movement and rotation speeds can be modified on Unity's interface.

 * GetComponent function wasn't used because transform can be accessed directly.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacterController : MonoBehaviour {

    public float traslationSpeed = 10;
    public float rotationSpeed = 2;

    void Update() {
      float distance = Time.deltaTime * traslationSpeed;
      transform.position += Vector3.forward * Input.GetAxis("Vertical") * distance;
      transform.position += Vector3.right * Input.GetAxis("Horizontal") * distance;
      transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * rotationSpeed, 0);
    }
}
