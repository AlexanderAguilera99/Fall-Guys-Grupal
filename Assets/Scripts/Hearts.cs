using UnityEngine;
using UnityEngine.SceneManagement;

public class Hearts : MonoBehaviour
{
    public int vidas = 3;
    public GameObject puntoInicioGO;
    private Vector3 puntoInicio;

    private void Start()
    {
        puntoInicio = puntoInicioGO.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trigger"))
        {
            vidas--;

            if (vidas <= 0)
            {
                transform.position = puntoInicio;
                vidas = 3;

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            else
            {
                transform.position = puntoInicio;
            }
        }
    }
}
