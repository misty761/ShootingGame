using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public static ItemManager instance;
    public GameObject prefCoin;
    public GameObject prefPowerUp;
    public GameObject prefFireUp;
    //public GameObject prefSpeedUp;
    public GameObject prefLifeUp;
    public GameObject prefSlowTime;
    public GameObject prefFreezeEnemy;
    public GameObject prefDestroyAllEnemy;
    public GameObject prefFloatingText;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("ItemManager : 씬에 두개 이상의 게임 오브젝트가 존재합니다!");
            Destroy(gameObject);
        }
    }

    public void SetFloatingText(string text, Vector3 pos)
    {
        GameObject floatingText = Instantiate(prefFloatingText);
        floatingText.transform.position = pos;
        floatingText.GetComponent<FloatingText>().itemName = text;
    }

}
