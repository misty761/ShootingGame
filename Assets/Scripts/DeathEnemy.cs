using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathEnemy : MonoBehaviour
{
    public GameObject effect;

    float speed = 5f;
    string stringDestroyAllEnemies;

    private void Start()
    {
        stringDestroyAllEnemies = LanguageManager.instance.SetText("Destroy all enemies");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.down;
        transform.position += dir * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Contains("Player"))
        {
            SoundControl.instance.PlaySound(SoundControl.instance.audioDestroyAllEnemy);

            // 플로팅 메세지 표시
            ItemManager.instance.SetFloatingText("Destroy all enemies!", transform.position);

            StartCoroutine(DestroyAllEnemy());    
        }

    }

    IEnumerator DestroyAllEnemy()
    {
        Instantiate(effect, Vector3.zero, Quaternion.Euler(0,0,0));
        speed = 0f;
        transform.position = new Vector3(10, 0, 0);
        GameManager.instance.bitDestroyAllEnemy = true;
        yield return new WaitForSeconds(0.1f);
        GameManager.instance.bitDestroyAllEnemy = false;
        Destroy(gameObject);
    }
}
