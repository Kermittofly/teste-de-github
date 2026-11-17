using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScene : MonoBehaviour
{
    public GameObject painelPause;
    public GameObject PainelGameOver;
    public GameObject Painelvitória;

    bool pausado = false;
    bool jogoAcabou = false;
    bool vitória = false;
    void Start()
    {
        painelPause.SetActive(false);
        PainelGameOver.SetActive(false);
        Painelvitória.SetActive(false);
    }

   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausado)
            {
                Continuar();
            }
            else
            {
                Pausar();
            }
        }
    }

    public void Pausar()
    {
        if (jogoAcabou == false && vitória == false)
        {
            pausado = true;
            painelPause.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void Continuar()
    {
        pausado = false;
        painelPause.SetActive(false);
        Time.timeScale = 1f;
    }

    public void MostrarGameOver()
    {
        jogoAcabou = true;
        PainelGameOver.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void VoltarMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void vitoria()
    {
        Time.timeScale = 0f;
        vitória = true;
        Painelvitória.SetActive(true);
    }
}
