using UnityEngine;
using UnityEngine.SceneManagement;
public class proxfase : MonoBehaviour
{
    GameObject Proxfase;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Proxfase != null)
            {
                SceneManager.LoadScene(2);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("proxfase"))
        {
            Proxfase = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("proxfase"))
        {
            if (collision.gameObject == Proxfase)
            {
                Proxfase = null;
            }
        }
    }
}
