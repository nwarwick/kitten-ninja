using UnityEngine;

public class DestroySelf : MonoBehaviour {

	public float distanceThresholdY = -20f;
	
	// Update is called once per frame
	void Update () {
		if(gameObject.transform.position.y <= distanceThresholdY)
		{
			Destroy(gameObject);
		}
	}
}
