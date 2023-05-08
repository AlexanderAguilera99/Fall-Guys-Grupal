using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScene : MonoBehaviour
{
    public float delayTime = 5f;

    public void Update()
    {
      StartCoroutine(ChangeScene());  
    }

    IEnumerator ChangeScene(){
        yield return new WaitForSeconds(delayTime);
        SceneManager.LoadScene("Nivel4_FallGuys");
    }
}
