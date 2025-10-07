using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    public void SceneBeach()
    {
        SceneManager.LoadScene("Praia");
    }

    public void SceneMinigame()
    {
        SceneManager.LoadScene("Minigame");
    }

    public void SceneTopDraft()
    {
        SceneManager.LoadScene("TopDown");
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void MenuConfig(GameObject menuConfig)
    {
        pauseMenu.SetActive(false);
        menuConfig.SetActive(true);
    }

    public void BackToPause(GameObject menuConfig)
    {
        menuConfig.SetActive(false);
        pauseMenu.SetActive(true);
    }

     public void QuitGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MenuPrincipal");
    }
}
