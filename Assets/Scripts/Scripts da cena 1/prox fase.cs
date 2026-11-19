using UnityEngine;
using UnityEngine.SceneManagement;
public class proxfase : MonoBehaviour
{
    GameObject Proxfase;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (Proxfase != null)
            {
                SceneManager.LoadScene(2);//ele carrega a proxima cena
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("proxfase"))
        {
            Proxfase = collision.gameObject;//Proxfase para de ser vazio e resebe uma colisão
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("proxfase"))
        {
            if (collision.gameObject == Proxfase)
            {
                Proxfase = null;//quando o Proxfase não tiver a colisão, ele se torna vazio
            }
        }
    }
}
