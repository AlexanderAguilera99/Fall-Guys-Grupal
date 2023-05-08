using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Se reusa mucho el código para cargar el nivel probablemente hay una mejor práctica para hacer esto
    public void StartGame()
    {
        SceneManager.LoadScene("Nivel1_FallGuys");
    }

    public void ShowCredits()
    {
        SceneManager.LoadScene("Nivel4_FallGuys");
    }
    public void ShowMenu()
    {
        SceneManager.LoadScene("Nivel0_FallGuys");
    }
   
}
