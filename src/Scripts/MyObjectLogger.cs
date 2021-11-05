/// Marcos Barrios
/// Interfaces Inteligentes ULL
/// 10.10.2021
///
/// Script para la Practica 1 de Introducción a Unity.
/// Logea todos los objetos utilizados en la escena que tengan asignados una
/// etiqueta.
/// 
/// Agrego la ID a la propiedad name de cada GameObject con etiqueta.
/// La ID es un entero que cuenta los objetos en la escena, amountOfObjectsUsed
/// 
/// Cada objeto tiene un contador (array counters) pero solo se imprime e
/// incrementa el contador de los objetos que tienen tag.
/// 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyObjectLogger : MonoBehaviour {
  
  private static int amountOfObjectsUsed = 1;

  private GameObject[] allObjects;
  private int[] counters;

  // Encontrar objetos y asignar IDs
  void Start() {
    allObjects = GameObject.FindObjectsOfType<GameObject>(true /* include inactive */);
    counters = new int[allObjects.Length];
    for (int i = 0; i < allObjects.Length; i++) {
      if (allObjects[i].tag != "Untagged") {
        allObjects[i].name += "_" + amountOfObjectsUsed;
        amountOfObjectsUsed++;
      }
    }
  }

  // Imprimir objetos con tag.
  void Update() {
    for (int i = 0; i < allObjects.Length; i++) {
      if (allObjects[i].tag != "Untagged") {
        Debug.Log(allObjects[i].ToString() + " " + counters[i]);
        counters[i]++;
      }
    }
  }

}
