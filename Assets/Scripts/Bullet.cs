using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float speed = 5f;
    int powerStart;
    int powerEnd;
    PlayerFire player;

    private void OnEnable()
    {
        if (GameManager.instance == null) return;

        powerStart = GameManager.instance.rocketPower;
    }

    private void Start()
    {
        player = FindObjectOfType<PlayerFire>();
    }

    // Update is called once per frame
    void Update()
    {
        // 이동
        Vector3 dir = Vector3.up;
        transform.position += dir * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        CollisionBullet();
    }

    public void CollisionBullet()
    {
        powerEnd = GameManager.instance.rocketPower;

        if (GameManager.instance.isGameOver || (powerStart != powerEnd))
        {
            // 오브젝트 파괴
            Destroy(gameObject);
        }
        else if (powerStart == powerEnd)
        {
            // 총알을 오브젝트 풀로 보냄
            gameObject.SetActive(false);
            player.bulletObjectPool.Add(gameObject);
        }
    }
}
