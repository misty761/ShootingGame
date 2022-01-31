using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPlaneButton : MonoBehaviour
{
    public GameObject buttonStart;
    public GameObject buttonBuy;

    public int selectedPlane;

    void Start()
    {
        buttonStart.SetActive(true);
        buttonBuy.SetActive(false);
        int planeNo = PlayerPrefs.GetInt("Plane", 0);   // 0~11
        Vector3 pos = new Vector3(0, 2.6f, 0);
        PlaneManager.instance.planes[planeNo].transform.localScale = new Vector3(2, 2, 2);
        Instantiate(PlaneManager.instance.planes[planeNo], pos, Quaternion.Euler(Vector3.zero));
    }

    public void Plane1()
    {
        SelectPlane(0);
    }

    public void Plane2()
    {
        SelectPlane(1);
    }

    public void Plane3()
    {
        SelectPlane(2);
    }

    public void Plane4()
    {
        SelectPlane(3);
    }

    public void Plane5()
    {
        SelectPlane(4);
    }

    public void Plane6()
    {
        SelectPlane(5);
    }

    public void Plane7()
    {
        SelectPlane(6);
    }

    public void Plane8()
    {
        SelectPlane(7);
    }

    public void Plane9()
    {
        SelectPlane(8);
    }

    public void Plane10()
    {
        SelectPlane(9);
    }

    public void Plane11()
    {
        SelectPlane(10);
    }

    public void Plane12()
    {
        SelectPlane(11);
    }

    void SelectPlane(int number)
    {
        SoundControl.instance.PlaySound(SoundControl.instance.audioClipClick);

        int buyPlane = PlayerPrefs.GetInt("BuyPlane" + number, 0);
        if (buyPlane == 1)
        {
            buttonStart.SetActive(true);
            buttonBuy.SetActive(false);
            PlayerPrefs.SetInt("Plane", number);
        }
        else
        {
            buttonStart.SetActive(false);
            buttonBuy.SetActive(true);
        }

        PlayerFire player = FindObjectOfType<PlayerFire>();
        Destroy(player.gameObject);
        Vector3 pos = new Vector3(0, 2.6f, 0);
        PlaneManager.instance.planes[number].transform.localScale = new Vector3(2, 2, 2);
        Instantiate(PlaneManager.instance.planes[number], pos, Quaternion.Euler(Vector3.zero));
        selectedPlane = number;
    }

}
