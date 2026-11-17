using UnityEngine;
using UnityEngine.SceneManagement;
public class trocadecena : MonoBehaviour
{
    GameObject Trocadecena;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (Trocadecena != null)
            {
                transform.position = Trocadecena.GetComponent<Transporte>().GetDestination().position;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Transporte"))
        {
                Trocadecena = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Transporte"))
        {
            if (collision.gameObject == Trocadecena)
            {
                Trocadecena = null;
            }
        }
    }

}