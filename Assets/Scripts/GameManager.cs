using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public HUD hud;

    private int vidas = 3;


    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.Log("ya hay un game manager");
        }
    }

    public void PerderVida()
    {
        vidas -= 1;
        hud.DesactivarVida(vidas);
    }
    
}
