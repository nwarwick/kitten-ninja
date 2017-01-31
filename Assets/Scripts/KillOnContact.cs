using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillOnContact : MonoBehaviour {
	GameManager gm;


	void Start()
	{
		if(gm == null)
        {
            gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        }
	}

	// Check if player hit a hazard
	void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(other.gameObject.tag);
        if(other.gameObject.tag == "Hazard"){
			gm.KillPlayer(gameObject);
        }
    }
}
