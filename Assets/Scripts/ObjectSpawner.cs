using System.Collections;
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
            yield return new WaitForSeconds(spawnDelay);
            Debug.Log("Spawning object");
            Instantiate(item, spawnPoint.position, spawnPoint.rotation);
        }
    }

}
