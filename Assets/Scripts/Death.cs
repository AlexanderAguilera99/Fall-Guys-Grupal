using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerCount : MonoBehaviour {

    public int requiredCount = 3; // número de veces que se debe pasar por el trigger
    private int currentCount = 0; // contador de veces que el personaje ha pasado por el trigger

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            currentCount++;
            if (currentCount >= requiredCount) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}

