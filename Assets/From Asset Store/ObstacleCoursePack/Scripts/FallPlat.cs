using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallPlat : MonoBehaviour
{
    private bool isPlayerTouching = false;
    private float timeToDisappear = 1f;
    private float timeToAppear = 2f;
    private float timer = 0f;
    private Vector3 initialPosition;
	public GameObject puntoInicioGO;

    void Start()
    {
        // Guardamos la posición inicial del objeto
        initialPosition = puntoInicioGO.transform.position;
    }

    void Update()
    {
        // Si el jugador ha tocado el objeto, iniciamos el temporizador
        if (isPlayerTouching)
        {
            timer += Time.deltaTime;
            // Si el temporizador ha superado el tiempo de desaparición, hacemos que el objeto desaparezca
            if (timer >= timeToDisappear)
            {
                gameObject.SetActive(false);
            }
            // Si el temporizador ha superado el tiempo de reaparición, hacemos que el objeto vuelva a aparecer en su posición inicial
            if (timer >= timeToAppear)
            {
                gameObject.SetActive(true);
                isPlayerTouching = false;
                timer = 0f;
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // El jugador ha tocado el objeto
            isPlayerTouching = true;
        }
    }
}