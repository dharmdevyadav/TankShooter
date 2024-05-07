using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    private int timeBetweenSpawn;
    private float NextspawnTime;
    public GameObject Coin;

    public Transform[] CoinPoint;
    void Update()
    {
        timeBetweenSpawn = Random.Range(3, 10);
        if (Time.time > NextspawnTime)
        {
            NextspawnTime = Time.time + timeBetweenSpawn;
            Transform randomSpawnPoint = CoinPoint[Random.Range(0, CoinPoint.Length)];
            var coinPrefeb=Instantiate(Coin, randomSpawnPoint.position, Quaternion.identity);
            Destroy(coinPrefeb,6);
        }
        
    }
}
