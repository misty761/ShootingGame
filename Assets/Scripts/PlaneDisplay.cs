using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneDisplay : MonoBehaviour
{
    public GameObject[] boughtPlanes;
    public GameObject[] notBoughtPlanes;

    private void Start()
    {
        PlayerPrefs.SetInt("BuyPlane0", 1); // 0:구매 전, 1:구매 완료
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < boughtPlanes.Length; i++)
        {
            int buyPlane = PlayerPrefs.GetInt("BuyPlane" + i, 0);
            if (buyPlane == 1)
            {
                boughtPlanes[i].SetActive(true);
                notBoughtPlanes[i].SetActive(false);
            }
            else
            {
                boughtPlanes[i].SetActive(false);
                notBoughtPlanes[i].SetActive(true);
            }
        }
        
    }
}
