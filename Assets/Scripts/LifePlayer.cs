using UnityEngine;
using UnityEngine.SceneManagement;

public class LifePlayer : MonoBehaviour
{
    public int vidas = 3;
    private int vecesPaso = 0;
    private Vector3 puntoInicio;

    private void Start()
    {
        puntoInicio = GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            vecesPaso++;

            if (vecesPaso >= 3)
            {
                Hearts jugadorVidas = other.gameObject.GetComponent<Hearts>();

                if (jugadorVidas != null)
                {
                    jugadorVidas.vidas--;
                    vecesPaso = 0;

                    if (jugadorVidas.vidas <= 0)
                    {
                        other.gameObject.transform.position = puntoInicio;
                        jugadorVidas.vidas = 3;

                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                    }
                    else
                    {
                        other.gameObject.transform.position = puntoInicio;
                    }
                }
            }
        }
    }
}

