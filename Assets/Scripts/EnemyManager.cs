using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager instance;
    public GameObject enemyFactory1;
    public GameObject enemyFactory2;
    public GameObject enemyFactory3;
    public GameObject enemyFactory4;
    public GameObject enemyFactory5;
    public GameObject enemyFactory6;
    public GameObject enemyFactory7;
    public GameObject enemyFactory8;
    public GameObject enemyFactory9;
    public GameObject enemyFactory10;
    public GameObject enemyFactory11;
    public GameObject enemyFactory12;
    public GameObject enemyFactory13;
    public Transform[] spawnPoints;

    public List<GameObject> enemyObjectPool;

    float minTime;
    float maxTime;
    float currentTime;
    float createTime;

    int poolSize = 128;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.Log("EnemyManager : 두개 이상의 게임 오브젝트가 존재합니다.");
            Destroy(this);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        Init();   
    }

    public void Init()
    {
        currentTime = 0f;
        minTime = 0.5f;
        maxTime = 1.5f;

        createTime = Random.Range(minTime, maxTime);

        enemyObjectPool = new List<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            float random = Random.Range(0f, 1f);

            float prob = (float)1/13;

            if (random < prob)
            {
                GameObject enemy = Instantiate(enemyFactory1);
                enemyObjectPool.Add(enemy);
                enemy.SetActive(false);
            }
            else if (random < prob * 2)
            {
                GameObject enemy = Instantiate(enemyFactory2);
                enemyObjectPool.Add(enemy);
                enemy.SetActive(false);
            }
            else if (random < prob * 3)
            {
                GameObject enemy = Instantiate(enemyFactory3);
                enemyObjectPool.Add(enemy);
                enemy.SetActive(false);
            }
            else if (random < prob * 4)
            {
                GameObject enemy = Instantiate(enemyFactory4);
                enemyObjectPool.Add(enemy);
                enemy.SetActive(false);
            }
            else if (random < prob * 5)
            {
                GameObject enemy = Instantiate(enemyFactory5);
                enemyObjectPool.Add(enemy);
                enemy.SetActive(false);
            }
            else if (random < prob * 6)
            {
                GameObject enemy = Instantiate(enemyFactory6);
                enemyObjectPool.Add(enemy);
                enemy.SetActive(false);
            }
            else if (random < prob * 7)
            {
                GameObject enemy = Instantiate(enemyFactory7);
                enemyObjectPool.Add(enemy);
                enemy.SetActive(false);
            }
            else if (random < prob * 8)
            {
                GameObject enemy = Instantiate(enemyFactory8);
                enemyObjectPool.Add(enemy);
                enemy.SetActive(false);
            }
            else if (random < prob * 9)
            {
                GameObject enemy = Instantiate(enemyFactory9);
                enemyObjectPool.Add(enemy);
                enemy.SetActive(false);
            }
            else if (random < prob * 10)
            {
                GameObject enemy = Instantiate(enemyFactory10);
                enemyObjectPool.Add(enemy);
                enemy.SetActive(false);
            }
            else if (random < prob * 11)
            {
                GameObject enemy = Instantiate(enemyFactory11);
                enemyObjectPool.Add(enemy);
                enemy.SetActive(false);
            }
            else if (random < prob * 12)
            {
                GameObject enemy = Instantiate(enemyFactory12);
                enemyObjectPool.Add(enemy);
                enemy.SetActive(false);
            }
            else
            {
                GameObject enemy = Instantiate(enemyFactory13);
                enemyObjectPool.Add(enemy);
                enemy.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.isGameOver) return;

        currentTime += Time.deltaTime;

        if (currentTime > createTime)
        {
            if (enemyObjectPool.Count > 0)
            {
                GameObject enemy = enemyObjectPool[0];
                enemy.SetActive(true);
                enemyObjectPool.Remove(enemy);
                int index = Random.Range(0, spawnPoints.Length);
                enemy.transform.position = spawnPoints[index].position;
            }
            createTime = Random.Range(minTime, maxTime);
            currentTime = 0f;

            minTime -= 0.004f;
            float minTimeLimit = 0.15f;
            if (minTime < minTimeLimit) minTime = minTimeLimit;
            maxTime -= 0.004f;
            if (maxTime < minTimeLimit) maxTime = minTimeLimit;    
        }
    }
}
