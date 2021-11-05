/**
 * Marcos Barrios
 * Interfaces Inteligentes
 * Move the GameObject using ILJM. It uses customized Input Axis.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ILJMCharacterControler : MonoBehaviour {

    public float traslationSpeed = 10;

    void Update() {
      float distance = Time.deltaTime * traslationSpeed;
      transform.position += Vector3.forward * Input.GetAxis("MyVertical") * distance;
      transform.position += Vector3.right * Input.GetAxis("MyHorizontal") * distance;
    }
}
