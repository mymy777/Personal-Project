using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerupPrefab;
    private float spawnRange = 15.0f;
    public int enemyCount;
    public int waveNumber = 1;

    // Start is called before the first frame update
    void Start()
    {
      //SpawnEnemyWave(waveNumber);
      //Instantiate(powerupPrefab,GenerateSpawnPosition(), powerupPrefab.transform.rotation);
      //StartCoroutine(SpawnEnemyWave());

    }

   //randomPos returns spawn positions for the enemies in the right areas
    /*public SpawnEnemyWave()
    {
      while(true)
      {
         Vector3 spawnPosition = new (randomPos);
      }
    }*/

    // Update is called once per frame

    void Update()
   {
      enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;

      if(enemyCount == 0)
      {
         waveNumber++;
         SpawnEnemyWave(waveNumber);
         Instantiate(powerupPrefab,GenerateSpawnPosition(), powerupPrefab.transform.rotation);
      }
   }

   public void SpawnEnemyWave(int enemiesToSpawn)
   {
      for (int i = 1; i < enemiesToSpawn; i++)
      {
         Debug.Log("working");
         Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
      }   
   }

    public Vector3 GenerateSpawnPosition()
    {
       float spawnPosX = Random.Range(-spawnRange, spawnRange);
       float spawnPosZ = Random.Range(-spawnRange, spawnRange);

       Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);

       return randomPos;
    }
}
