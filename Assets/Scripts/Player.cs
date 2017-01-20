using UnityEngine;

public class Player : MonoBehaviour
{

    [System.SerializableAttribute]
    public class PlayerStats
    {
        public float health = 100f;
    }

    public PlayerStats playerStats = new PlayerStats();
    public GameManager gm;
	public float fallBoundary = -10;

    void Start()
    {
        if(gm == null)
        {
            gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= fallBoundary)
        {
			DamagePlayer(Mathf.Infinity);
        }
    }

    // Damages the player
    void DamagePlayer(float amount)
    {
        playerStats.health -= amount;

        if (playerStats.health <= 0)
        {
            gm.KillPlayer(this);
        }
    }
}
