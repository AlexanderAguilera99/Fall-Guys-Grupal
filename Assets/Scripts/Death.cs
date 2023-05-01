using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour {

    public int requiredCount = 3; // número de veces que se debe pasar por el trigger
    public int currentCount = 0; // contador de veces que el personaje ha pasado por el trigger
   // public Transform checkPoint;
    void OnTriggerEnter(Collider col) {
        if (col.gameObject.CompareTag("Player")) {
            currentCount++;
            GameManager.Instance.PerderVida();
            //con esta linea cargo desde el punto de chequeo
            //col.gameObject.GetComponent<CharacterControls>().checkPoint = checkPoint.position;
            //col.gameObject.GetComponent<CharacterControls>().LoadCheckPoint();
            if (currentCount >= requiredCount) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}

