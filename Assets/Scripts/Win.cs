using UnityEngine;

public class Win : MonoBehaviour {

	public GameManager gm;

	void Start()
    {
        if(gm == null)
        {
            gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        }
    }

	void OnTriggerEnter2D(Collider2D other)
	{
		// Check if the colliding object is the player
		Player player = other.gameObject.GetComponent<Player>();
		if (player != null)
		{
			gm.Win(player); // Pass the player because we have to destroy the game object
		}
	}
}
