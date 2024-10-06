using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] GameObject prefab;

    [SerializeField] float spawnTime = 3f;
    [SerializeField] float minHeight = -1f;
    [SerializeField] float maxHeight = 3f;

    void Start()
    {
        InvokeRepeating("SpawnPipe", 0, spawnTime);        
    }

    void SpawnPipe(){
        float randomY = Random.Range(minHeight, maxHeight);

        Vector3 spawnPos = new Vector3(transform.position.x, randomY, 0);

        Instantiate(prefab, spawnPos, Quaternion.identity); 
    }
}
