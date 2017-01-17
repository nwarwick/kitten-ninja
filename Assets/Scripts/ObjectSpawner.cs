using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

    public GameObject item; // Item to spawn
    public Transform spawnPoint; // Where to spawn it
    public float spawnDelay = 5f; // How often to spawn it

    void Start()
    {
        StartCoroutine("SpawnObjects");
    }

    IEnumerator SpawnObjects()
    {
        while (true)
        {
            Debug.Log("Spawning object");
            yield return new WaitForSeconds(spawnDelay);
            GameObject newObject = Instantiate(item, spawnPoint.position, spawnPoint.rotation);
        }
    }

}
