using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    private int timeBetweenSpawn;
    private float NextspawnTime;
    public GameObject Coin;

    public Transform[] CoinPoint;
    void Update()
    {
        timeBetweenSpawn = Random.Range(6, 15);
        if (Time.time > NextspawnTime)
        {
            NextspawnTime = Time.time + timeBetweenSpawn;
            Transform randomSpawnPoint = CoinPoint[Random.Range(0, CoinPoint.Length)];
            Instantiate(Coin, randomSpawnPoint.position, Quaternion.identity);
        }
        
    }
}
