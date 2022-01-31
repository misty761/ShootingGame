using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public GameObject newRecordText;
    public Text currentScoreUI;
    public Text bestScoreUI;

    int currentScore;
    int bestScore;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            // instance에 이미 다른 오브젝트가 할당되어 있는 경우
            // 씬에 두개 이상의 오브젝트가 존재한다는 의미.
            // 싱글톤 오브젝트는 하나만 존재해야 하므로 자신의 게임 오브젝트를 파괴
            Debug.LogWarning("ScoreManager : 씬에 두개 이상의 게임 오브젝트가 존재합니다.");
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;

        bestScore = PlayerPrefs.GetInt("BestScore", 0);
        //bestScoreUI.text = "Best : " + bestScore;
        LanguageManager.instance.SetTextBestScore(bestScoreUI, bestScore);

        //PlayerPrefs.SetInt("BestScore", 0);     // 기록 0점으로(개발용)
    }

    public int Score
    {
        get
        {
            return currentScore;
        }
        set
        {
            currentScore = value;
            currentScoreUI.text = "" + currentScore;
            
            if (currentScore > bestScore)
            {
                bestScore = currentScore;
                //bestScoreUI.text = "Best : " + bestScore;
                LanguageManager.instance.SetTextBestScore(bestScoreUI, bestScore);
                PlayerPrefs.SetInt("BestScore", bestScore);
            }
        }
    }

    public void CheckNewRecord()
    {
        if (currentScore >= bestScore)
        {
            SoundControl.instance.PlaySound(SoundControl.instance.audioClipFanfare);
            newRecordText.SetActive(true);
        }
        else
        {
            SoundControl.instance.PlaySound(SoundControl.instance.audioClipGameOver);
            newRecordText.SetActive(false);
        }
    }

}
