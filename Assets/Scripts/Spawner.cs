using UnityEngine;

public class Spawner : MonoBehaviour
{
    private int timeBetweenSpawn;
    private float NextspawnTime;
    public GameObject Enemy;

    public Transform[] SpawnPoint;
    
    void Update()
    {
        timeBetweenSpawn = Random.Range(3, 12);
        if (Time.time > NextspawnTime)
        {
            NextspawnTime = Time.time+timeBetweenSpawn;
            Transform randomSpawnPoint = SpawnPoint[Random.Range(0,SpawnPoint.Length)];
            Instantiate(Enemy, randomSpawnPoint.position,Quaternion.identity);
        }
    }
}
