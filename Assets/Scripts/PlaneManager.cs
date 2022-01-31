using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneManager : MonoBehaviour
{
    public static PlaneManager instance;
    public GameObject[] planes;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("PlaneManager : 씬에 두개 이상의 게임 오브젝트가 존재합니다!");
            Destroy(gameObject);
        }
    }
}
