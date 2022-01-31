using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject explosionFactory;
    
    float speed = 5f;
    float originalSpeed;
    GameObject target;
    Vector3 dir;
    PlayerFire player;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerFire>();
        target = player.gameObject;

        int randValue = Random.Range(0, 10);

        // 3보다 작으면 플레이어를 향해 내려옴
        if (randValue < 5 && target != null)
        {
            dir = target.transform.position - transform.position;
            dir.Normalize();
        }
        // 그렇지 않은 경우 아래로 내려옴
        else
        {
            dir = Vector3.down;
        }

        originalSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.isGameOver)
        {
            // 게임 오브젝트 파괴
            Destroy(this.gameObject);
        }
        else
        {
            // 이동
            transform.position += dir * speed * Time.deltaTime;
        }

        // 플레이어가 얼음 아이템을 먹으면 정지
        if (GameManager.instance.bitFreeze)
        {
            speed = 0f;
        }
        else speed = originalSpeed;

        // 플레이어가 해골 아이템을 먹으면 모든 적 파괴
        if (GameManager.instance.bitDestroyAllEnemy)
        {
            // 폭발 소리
            SoundControl.instance.PlaySound(SoundControl.instance.audioExplosion);

            // 폭발 효과
            GameObject explosion = Instantiate(explosionFactory);
            explosion.transform.position = transform.position;

            // 게임 오브젝트 비활성, 오브젝트 풀로 보내기
            gameObject.SetActive(false);
            GameObject emObject = GameObject.Find("EnemyManager");
            EnemyManager manager = emObject.GetComponent<EnemyManager>();
            manager.enemyObjectPool.Add(gameObject);

            // 점수 추가
            ScoreManager.instance.Score++;

            // 아이템 생성
            SpawnItem();
        }

    }

    private void OnCollisionEnter(Collision other)
    {
        if (GameManager.instance.isGameOver) return;

        if (other.gameObject.name.Contains("Bullet"))
        {
            Explosion(other);

            ScoreManager.instance.Score++;

            // 아이템 생성
            SpawnItem();
            
        }
        // 플레이어와 충돌
        else if (other.gameObject.name.Contains("Player"))
        {
            Explosion(other);

            player.life--;

            int playerLife = player.life;

            // 게임 오버
            if (playerLife <= 0)
            {
                ScoreManager.instance.CheckNewRecord();

                GameManager.instance.isGameOver = true;
            }
            else
            {
                other.gameObject.SetActive(true);
            }

        }
    }   

    void Explosion(Collision collison)
    {
        // 폭발 소리
        SoundControl.instance.PlaySound(SoundControl.instance.audioExplosion);

        // 폭발 효과
        GameObject explosion = Instantiate(explosionFactory);
        Vector3 pos = collison.contacts[0].point + new Vector3(0, 0, 0);
        explosion.transform.position = pos;

        // 게임 오브젝트 비활성, 오브젝트 풀로 보내기
        gameObject.SetActive(false);
        GameObject emObject = GameObject.Find("EnemyManager");
        EnemyManager manager = emObject.GetComponent<EnemyManager>();
        manager.enemyObjectPool.Add(gameObject);

        // 상대 게임 오브젝트 비활성
        collison.gameObject.SetActive(false);
    }

    void SpawnItem()
    {
        float random = Random.Range(0f, 1f);
        float prob = 0.01f;

        if (random < prob)
        {
            GameObject coin = Instantiate(ItemManager.instance.prefCoin);
            coin.transform.position = transform.position;
        }
        else if (random < prob * 2)
        {
            Instantiate(ItemManager.instance.prefLifeUp, transform.position, Quaternion.Euler(0, 0, 0));
        }
        else if (random < prob * 3)
        {
            if (Time.timeScale == 1)
            {
                Instantiate(ItemManager.instance.prefSlowTime, transform.position, Quaternion.Euler(0, 0, 0));
            } 
        }
        else if (random < prob * 4)
        {
            if (!GameManager.instance.bitFreeze)
            {
                Instantiate(ItemManager.instance.prefFreezeEnemy, transform.position, Quaternion.Euler(0, 0, 0));
            }
        }
        else if (random < prob * 5)
        {
            Instantiate(ItemManager.instance.prefDestroyAllEnemy, transform.position, Quaternion.Euler(0, 0, 0));
        }
        else if (random < prob * 10)
        {
            GameObject powerUp = Instantiate(ItemManager.instance.prefPowerUp);
            powerUp.transform.position = transform.position;
        }
        else if (random < prob * 15)
        {
            GameObject fireUp = Instantiate(ItemManager.instance.prefFireUp);
            fireUp.transform.position = transform.position;
        }
    }

}
