using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldManager : MonoBehaviour
{
    public static GoldManager instance;

    public int gold;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("MoneyManager : 두개 이상의 게임 오브젝트가 존재합니다.");
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        // 골드 증가(개발용)
        //PlayerPrefs.SetInt("Gold", 100);

        gold = PlayerPrefs.GetInt("Gold", 0);
        //DontDestroyOnLoad(gameObject);
    }

}
