using UnityEngine;

public class alavanca : MonoBehaviour
{
    public GameObject Ativação;
    bool ativável = false;

    private void Start()
    {
        Ativação.SetActive(false);
    }

    void Update()
    {
        if(ativável != false && Input.GetKeyDown(KeyCode.G))
        {
            Ativação.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ativável"))
        {
            ativável = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("ativável"))
        {
            ativável = false;
        }
    }
}
