using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Bullet") || other.gameObject.name.Contains("Enemy"))
        {
            other.gameObject.SetActive(false);
            if (other.gameObject.name.Contains("Enemy"))
            {
                GameObject emObject = GameObject.Find("EnemyManager");
                EnemyManager manager = emObject.GetComponent<EnemyManager>();
                manager.enemyObjectPool.Add(other.gameObject);
            }
            else
            {
                GameObject objectBullet = other.gameObject;
                Bullet bullet = objectBullet.GetComponent<Bullet>();
                bullet.CollisionBullet();
            }
        }
        else
        {
            Destroy(other.gameObject);
        }
        
    }
}
