using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

	// Start the game
    public void StartGame()
    {
		SceneManager.LoadScene("MainScene");
    }

	// Quit the game
	public void Quit()
	{
		Application.Quit();
	}
}
