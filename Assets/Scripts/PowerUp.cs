using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    float speed = 5f;
    string stringBonus;
    string stringPower;

    private void Start()
    {
        stringBonus = LanguageManager.instance.SetText("Bonus");
        stringPower = LanguageManager.instance.SetText("Power");
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
            PlayerFire player = FindObjectOfType<PlayerFire>();

            GameManager.instance.rocketPower++;
            int rocket = GameManager.instance.rocketPower;
            if (rocket > 5)
            {
                SoundControl.instance.PlaySound(SoundControl.instance.audioScore);

                GameManager.instance.rocketPower = 5;

                int score = 10;

                ScoreManager.instance.Score += score;

                ItemManager.instance.SetFloatingText(stringBonus + " +" + score, transform.position);

            } 
            else
            {
                SoundControl.instance.PlaySound(SoundControl.instance.audioPowerUp);

                // 플로팅 메세지 표시
                ItemManager.instance.SetFloatingText(stringPower + " +", transform.position);
            }
            if (rocket == 1) player.LoadRocket(player.bulletFactory1);
            else if (rocket == 2) player.LoadRocket(player.bulletFactory2);
            else if (rocket == 3) player.LoadRocket(player.bulletFactory3);
            else if (rocket == 4) player.LoadRocket(player.bulletFactory4);
            else if (rocket == 5) player.LoadRocket(player.bulletFactory5);    
        }

        Destroy(this.gameObject);
    }
}
