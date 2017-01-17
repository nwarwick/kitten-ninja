using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{

	// Quits the game
    public void Quit()
    {
		Application.Quit();	
    }

	// Loads the main menu
	public void MainMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}

	// Restart the game
    public void Restart()
    {
		SceneManager.LoadScene("MainScene");
    }
}
