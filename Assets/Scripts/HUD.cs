using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour
{
    public GameObject[] Vidas;

    public void DesactivarVida(int indice)
    {
        Vidas[indice].SetActive(false);
    }
}
