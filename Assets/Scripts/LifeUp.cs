using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeUp : MonoBehaviour
{
    float speed = 5f;
    PlayerFire player;
    string stringBonus;
    string stringLife;

    private void Start()
    {
        player = FindObjectOfType<PlayerFire>();

        stringBonus = LanguageManager.instance.SetText("Bonus");
        stringLife = LanguageManager.instance.SetText("Life");
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
            int playerLife = player.life;

            if (playerLife < 3)
            {
                SoundControl.instance.PlaySound(SoundControl.instance.audioLifeUp);

                player.life++;

                ItemManager.instance.SetFloatingText(stringLife + " +1", transform.position);
            }
            else
            {
                SoundControl.instance.PlaySound(SoundControl.instance.audioScore);

                int score = 10;

                ScoreManager.instance.Score += score;

                ItemManager.instance.SetFloatingText(stringBonus + " +" + score, transform.position);
            }
   
        }

        Destroy(this.gameObject);
    }
}
