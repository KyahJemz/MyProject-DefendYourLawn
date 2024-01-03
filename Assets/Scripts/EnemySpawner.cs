using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public float spawnRate;
    private void Start()
    {
        StartSpawning();
    }
    public void StartSpawning()
    {
        InvokeRepeating("SpawnZombie",1f,spawnRate);
    }
    void SpawnZombie()
    {
        float randomX = Random.Range(-2.11f, 1.83f);
        Vector2 spawnPosition = new Vector2(randomX, transform.position.y);
        Instantiate(enemy, spawnPosition, Quaternion.identity);

        float randomNumber = Random.Range(1, 4);
        switch (randomNumber)
        {
            case 1:
                {
                    AudioManager.instance.Audio_ZombieGroan();
                    break;
                }
            default:
                break;
        }
    }
    public void StopSpawning()
    {
        CancelInvoke("SpawnZombie");
    }
}
