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

            GameManager.Instance.PerderVida();

            if (vidas <= 0)
            {
                SceneManager.LoadScene("Nivel5_GameOver");
            }
            else
            {
                transform.position = puntoInicio;
            }
        }
    }
}
