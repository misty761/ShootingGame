using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireUp : MonoBehaviour
{
    float speed = 5f;
    string stringBonus;
    string stringFireSpeed;

    private void Start()
    {
        stringBonus = LanguageManager.instance.SetText("Bonus");
        stringFireSpeed = LanguageManager.instance.SetText("Fire speed");
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
            // 로켓 발사 속도 빠르게
            PlayerFire player = FindObjectOfType<PlayerFire>();
            player.intervalFire -= 0.05f;
            float fireSpeed = player.intervalFire;
            float minFireSpeed = 0.2f;
            if (fireSpeed < minFireSpeed)
            {
                SoundControl.instance.PlaySound(SoundControl.instance.audioScore);

                player.intervalFire = minFireSpeed;

                int score = 10;

                ScoreManager.instance.Score += score;

                ItemManager.instance.SetFloatingText(stringBonus + " +" + score, transform.position);
            } 
            else
            {
                SoundControl.instance.PlaySound(SoundControl.instance.audioFireUp);

                // 플로팅 메세지 표시
                ItemManager.instance.SetFloatingText(stringFireSpeed + " +", transform.position);
            }            
        }

        // 게임 오브젝트 파괴
        Destroy(this.gameObject);
    }
}
