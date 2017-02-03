using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour
{

    public static GameManager gm;
    public float playerLives = 3f;
    public Text uiLifeCount; // Text for number of player lives
    public Transform playerPrefab;
    public Transform playerSpawnPoint;

    [SerializeField]
    private GameObject gameOverScreen;
    [SerializeField]
    private GameObject victoryScreen;

    void Start()
    {
        gm = gameObject.GetComponent<GameManager>();
    }

    // Could also just pass the player gameobject
    public void KillPlayer(GameObject player)
    {
        playerLives -= 1f;
        uiLifeCount.text = "Lives: " + playerLives.ToString();

        
         StartCoroutine(DyingAnimation(player));

        
    }

    IEnumerator DyingAnimation(GameObject player)
    {
        Destroy(player);
        // Play animation here
        yield return new WaitForSeconds(1f);  
        // Check if player is out of lives and either end game or respawn the player
        if (playerLives <= 0)
        {
            GameOver();
        }
        else
        {
            RespawnPlayer();
        }  
                
    }

    public void RespawnPlayer()
    {
        Debug.Log("Respawning player..");
        var newPlayer = Instantiate(playerPrefab, playerSpawnPoint.position, playerSpawnPoint.rotation);
        newPlayer.name = "Player";
    }

    public void GameOver()
    {
        Debug.Log("GAME OVER");
        gameOverScreen.SetActive(true);
    }

    public void Win(Player player)
    {
        Debug.Log("Victory!");
        victoryScreen.SetActive(true);
        Destroy(player.gameObject);
    }
}
