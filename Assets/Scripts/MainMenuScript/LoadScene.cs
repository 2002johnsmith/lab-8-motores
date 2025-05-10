using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void Scenes(string scene)
    {
        Time.timeScale = 1.0f;
        GameManager.Instance.ResetGame();
        SceneManager.LoadScene(scene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
