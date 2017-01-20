using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    // Start the game
    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    // Open options menu
    public void Options()
    {
        SceneManager.LoadScene("OptionsMenu");
    }

    // Open about menu
    public void About()
    {
        SceneManager.LoadScene("AboutMenu");
    }

    // Open highscore menu
    public void HighScore()
    {
        SceneManager.LoadScene("HighScoreMenu");
    }

    // Open main menu
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Quit the game
    public void Quit()
    {
        Application.Quit();
    }
}
