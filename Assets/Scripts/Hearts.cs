using UnityEngine;
using UnityEngine.SceneManagement;

public class Hearts : MonoBehaviour
{
    public int vidas = 1;
    public int vecesPaso = 0;
    private Vector3 puntoInicio;
    public GameObject startPoint;

    private void Start()
    {
        puntoInicio = new Vector3(0, 0, 0);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Trigger"))
        {
            vecesPaso++;

            if (vecesPaso >= 3)
            {
                vidas--;

                if (vidas <= 0)
                {
                    transform.position = puntoInicio;
                    vidas = 1;

                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                }
                else
                {
                    transform.position = puntoInicio;
                }

                vecesPaso = 0;
            }
        }
    }
}
