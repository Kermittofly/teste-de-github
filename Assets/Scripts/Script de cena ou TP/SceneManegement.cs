using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManegement : MonoBehaviour
{
   
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");//inicial a primeira cena do jogo ao inicialo
    }

    public void QuitGame()
    {
        Application.Quit();//faz a aplição de sair do jogo, o jogo só é enserrado se estiver em um executável
    }

}
