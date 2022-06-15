using UnityEngine;
[System.Serializable]


public class Wave
{
    public int NbrEnemies;
    public GameObject[] typeofenemies;
    public float Startspawn;
}

public class WaveSpawner : MonoBehaviour
{
    public Wave[] waves;
    public Transform[] spawnPoints;
    private Wave currentWave;
    private int currentWaveNumber;
    private bool canSpawn = true;
    private float NextSpawnTime;
    private void Update()
    {
        currentWave = waves[currentWaveNumber];
        Spawnwave();
        GameObject[] TotalEnemies = GameObject.FindGameObjectsWithTag("damage");
        if (TotalEnemies.Length == 0 && !canSpawn && currentWaveNumber + 1 != waves.Length)
        {
            Next();
        }


    }
    void Next()
    {
        currentWaveNumber++;
        canSpawn = true;
    }
    void Spawnwave()
    {
        if (canSpawn && NextSpawnTime < Time.time)
        {
            GameObject randomEnemy = currentWave.typeofenemies[Random.Range(0, currentWave.typeofenemies.Length)];
            Transform randomPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
            Instantiate(randomEnemy, randomPoint.position, Quaternion.identity);
            currentWave.NbrEnemies--;
            NextSpawnTime = Time.time + currentWave.Startspawn;
            if (currentWave.NbrEnemies == 0)
            {
                canSpawn = true ;
            }
        }
        
    }
}


