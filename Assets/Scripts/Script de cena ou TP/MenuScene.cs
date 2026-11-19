using UnityEditor;
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
        //todos os paineis são inicialmente desativados
    }

   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausado)
            {
                Continuar();//se bool de pausado for falso ele continua o jogo
            }
            else
            {
                Pausar();// se bool de pausado for verdadeiro ele pausa o jogo
            }
        }
    }

    public void Pausar()
    {
        if (jogoAcabou == false && vitória == false) 
        {
            pausado = true;//bool se torna true possibilitando a ela de pause
            painelPause.SetActive(true);//ativa a tela de pause
            Time.timeScale = 0f;//torna o tempo do jogo 0, pausando o jogo
        }
    }

    public void Continuar()
    {
        pausado = false;//bool se torna false impedindo que ele dê pause
        painelPause.SetActive(false);//desativa a tela de pause
        Time.timeScale = 1f;//volta o fluxo do jogo o destravando
    }

    public void MostrarGameOver()
    {
        jogoAcabou = true;//bool se torna true possibilitando a tela de gameover
        PainelGameOver.SetActive(true);//ativa a tela de gameover
        Time.timeScale = 0f;
    }

    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);//ele carrega a cena atual ao clicar em reiniciar
    }

    public void VoltarMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);//ele carrega a cena, voltanedo para a cen de menu
    }

    public void vitoria()
    {
        Time.timeScale = 0f;
        vitória = true;//bool se torna true possibilitando a tela vitória
        Painelvitória.SetActive(true);//ativa a tela de vitória
    }
}
