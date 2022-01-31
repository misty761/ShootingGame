using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject gameoverMenu;
    public GameObject playerLife;
    public GameObject uiTimeFreeze;
    public GameObject uiTimeSlow;
    public GameObject uiGoToTitle;
    public GameObject[] playerlives;

    public bool isGameOver;
    public bool bitFreeze;
    public bool bitDestroyAllEnemy;
    public int rocketPower;
    public float timeFreeze;
    public float timeSlow;
    public PlayerFire player;
    GameObject objectPlayer;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("씬에 두개 이상의 게임 매니저가 존재합니다!");
            Destroy(gameObject);
        }

        // 플레이어 생성
        int planeNumber = PlayerPrefs.GetInt("Plane", 0);
        Vector3 pos = new Vector3(0, -4, 0);
        for (int i = 0; i < PlaneManager.instance.planes.Length; i++)
        {
            if (planeNumber == i)
            {
                PlaneManager.instance.planes[i].transform.localScale = new Vector3(1, 1, 1);
                objectPlayer = Instantiate(PlaneManager.instance.planes[i], pos, Quaternion.Euler(Vector3.zero));
            }    
        }
        player = objectPlayer.GetComponent<PlayerFire>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    public void Init()
    {
        isGameOver = false;
        rocketPower = 0;
        bitFreeze = false;
        bitDestroyAllEnemy = false;
        Time.timeScale = 1; 
    }

    // Update is called once per frame
    void Update()
    {
        // 게임오버 메뉴 표시 여부
        if (isGameOver)
        {
            gameoverMenu.SetActive(true);
            playerLife.SetActive(false);
            uiTimeFreeze.SetActive(false);
            uiTimeSlow.SetActive(false);
        }
        else
        {
            gameoverMenu.SetActive(false);
            playerLife.SetActive(true);
        }

        // freeze 시간 표시
        if (bitFreeze)
        {
            timeFreeze -= Time.deltaTime;
            uiTimeFreeze.SetActive(true);
            Text time = uiTimeFreeze.GetComponentInChildren<Text>();
            time.text = "" + (int) timeFreeze;  
        }
        else
        {
            uiTimeFreeze.SetActive(false);
        }

        // slow 시간 표시
        if (Time.timeScale == 0.5f)
        {
            timeSlow -= Time.deltaTime;
            uiTimeSlow.SetActive(true);
            Text time = uiTimeSlow.GetComponentInChildren<Text>();
            time.text = "" + (int)timeSlow;
        }
        else
        {
            uiTimeSlow.SetActive(false);
        }

        // back button
        if (Input.GetKey(KeyCode.Escape))
        {
            uiGoToTitle.SetActive(true);
            Time.timeScale = 0;
        }

        // 라이프 표시
        if (player.life == 0)
        {
            playerlives[0].SetActive(false);
            playerlives[1].SetActive(false);
            playerlives[2].SetActive(false);
        }
        else if (player.life == 1)
        {
            playerlives[0].SetActive(true);
            playerlives[1].SetActive(false);
            playerlives[2].SetActive(false);
        }
        else if (player.life == 2)
        {
            playerlives[0].SetActive(true);
            playerlives[1].SetActive(true);
            playerlives[2].SetActive(false);
        }
        else if (player.life == 3)
        {
            playerlives[0].SetActive(true);
            playerlives[1].SetActive(true);
            playerlives[2].SetActive(true);
        }

    }

    public void RetryGame()
    {
        Init();
        EnemyManager.instance.Init();
        player.gameObject.SetActive(true);
        player.transform.position = player.originalPosition;
        player.Init();
        //TouchMove touch = FindObjectOfType<TouchMove>();
        //touch.speed = 5f;
        ScoreManager.instance.Score = 0;
        GoogleMobileAdsReward googleAD = FindObjectOfType<GoogleMobileAdsReward>();
        googleAD.MyLoadAD();
    }

}
