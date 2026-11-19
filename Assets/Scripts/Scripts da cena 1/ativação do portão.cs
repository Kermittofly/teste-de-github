using UnityEngine;

public class ativaçãodoportão : MonoBehaviour
{
    public GameObject Ativação;
    bool ativável = false;

    private void Start()
    {
        Ativação.SetActive(false);//inicialmente o objeto que vai ser ativado vai estar desligado
    }

    void Update()
    {
        if (ativável != false && Input.GetKeyDown(KeyCode.Y))// apenas se a tecla for pressionada e estiver disponível a ativaão irá funcionar
        {
            Ativação.SetActive(true);// ativação
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ativável 2"))
        {
            ativável = true;//se o colisor de algo como um botão ou alavanca estiver encostando no player ele vai ativar o mesmo
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("ativável 2"))
        {
            ativável = false;//vai remocver a opção de ativar se não estiverem colidindo
        }
    }
}
