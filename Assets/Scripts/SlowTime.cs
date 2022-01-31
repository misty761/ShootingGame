using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTime : MonoBehaviour
{
    float speed = 5f;
    string stringSlow;

    private void Start()
    {
        stringSlow = LanguageManager.instance.SetText("Slow");
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
            SoundControl.instance.PlaySound(SoundControl.instance.audioWatch);

            // 플로팅 메세지 표시
            ItemManager.instance.SetFloatingText(stringSlow, transform.position);

            StartCoroutine(MakeSlow());         
        }  
    }

    IEnumerator MakeSlow()
    {
        float time = 5f;
        GameManager.instance.timeSlow = time + 1f;
        speed = 0f;
        transform.position = new Vector3(10, 0, 0);
        Time.timeScale = 0.5f;
        yield return new WaitForSeconds(time);
        Time.timeScale = 1f;
        Destroy(gameObject);
    }
}
