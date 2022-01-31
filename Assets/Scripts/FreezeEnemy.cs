using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeEnemy : MonoBehaviour
{
    public GameObject effect;
    
    float speed = 5f;
    string stringFreeze;

    private void Start()
    {
        stringFreeze = LanguageManager.instance.SetText("Freeze");
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
            SoundControl.instance.PlaySound(SoundControl.instance.audioFreeze);

            // 플로팅 메세지 표시
            ItemManager.instance.SetFloatingText(stringFreeze, transform.position);

            StartCoroutine(StopEnemy());  
        }
    }

    IEnumerator StopEnemy()
    {
        GameObject effectSnow = Instantiate(effect, new Vector3(0, 5, 0), Quaternion.Euler(0, 0, 0));
        float time = 3f;
        GameManager.instance.timeFreeze = time + 1f;
        speed = 0f;
        transform.position = new Vector3(10, 0, 0);
        GameManager.instance.bitFreeze = true;
        yield return new WaitForSeconds(time);
        GameManager.instance.bitFreeze = false;
        Destroy(effectSnow);
        Destroy(gameObject);
    }
}
