using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class EnemyPool : MonoBehaviour
{

    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private int poolSize = 10;
    [SerializeField] private Vector2 spawnAreaMin = new Vector2(3f, 3f);
    [SerializeField]private Vector2 spawnAreaMax = new Vector2( 5f, 5f);
    private float Delay = 10f;
   

    private List<GameObject> enemies = new List<GameObject>();

    void Start()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject enemy = Instantiate(enemyPrefab);

            enemy.SetActive(false);

            enemies.Add(enemy);
            
        }
        SpawnWave();
    }

    public GameObject GetEnemy()
    {
        foreach (GameObject enemy in enemies)
        {
            if(!enemy.activeSelf)
            {
                return enemy;
            }
        }
        return null;
    }
    
    public void SpawnEnemy(Vector2 position)
    {
        GameObject enemy = GetEnemy();

        if(enemy == null)
        {
            Debug.Log("Brak enemy");
            return;
        }

        enemy.transform.position = position;
        enemy.SetActive(true);
        
    }

    private void SpawnWave()
    {

       

        foreach (GameObject enemy in enemies)
        {
            Vector2 randomPos = new Vector2(
                Random.Range(spawnAreaMin.x, spawnAreaMax.x),
                Random.Range(spawnAreaMin.x, spawnAreaMax.y));

            enemy.transform.position = randomPos;
            enemy.SetActive(true);
        }

    }

    public void OnEnemyDeath(GameObject enemy)
    {
        enemy.SetActive(false);

        bool allDead = true;
        foreach(GameObject e in enemies)
        {
            if(e.activeSelf)
            {
                allDead = false;
                break;
            }
        }
        if(allDead)
        {
           StartCoroutine(SpawnEnemiesNow());
        }
    }
    IEnumerator SpawnEnemiesNow()
    {
        yield return new WaitForSeconds(Delay);
        SpawnWave();
    }

   
}
