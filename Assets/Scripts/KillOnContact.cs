using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillOnContact : MonoBehaviour {
	GameManager gm;

    // Handle camera shaking
    public float shakeAmt = 0.1f;
    public float shakeLen = 0.2f;

    CameraShake camShake;

	void Start()
	{
		if(gm == null)
        {
            gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        }

        camShake = gm.GetComponent<CameraShake>();

        if(camShake == null)
        {
            Debug.LogError("No camera shake script found");
        }
	}

	// Check if player hit a hazard
	void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Hazard"){
            camShake.Shake(shakeAmt, shakeLen);
			gm.KillPlayer(gameObject);
        }
    }
}
