using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Map_Scene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
