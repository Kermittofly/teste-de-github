using UnityEngine;
using UnityEngine.SceneManagement;
public class trocadecena : MonoBehaviour
{
    GameObject Trocadecena;

    void Update()//quando troca de cena for diferente de vazio ele vai ser levado para onde o transporte tem o numeral
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (Trocadecena != null)
            {
                transform.position = Trocadecena.GetComponent<Transporte>().GetDestination().position;//transforma a posição de quem tem o código pegando o destino retornado o scrip transporte
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Transporte"))
        {
                Trocadecena = collision.gameObject;//troca de cena para de ser vazio e resebe uma colisão
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Transporte"))
        {
            if (collision.gameObject == Trocadecena)
            {
                Trocadecena = null;//quando o trocadecena não tiver a colisão, ele se torna vazio
            }
        }
    }

}