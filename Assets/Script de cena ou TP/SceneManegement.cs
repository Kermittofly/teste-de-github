using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManegement : MonoBehaviour
{
   
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
