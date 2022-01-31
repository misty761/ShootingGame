using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletFactory;
    public GameObject bulletFactory1;
    public GameObject bulletFactory2;
    public GameObject bulletFactory3;
    public GameObject bulletFactory4;
    public GameObject bulletFactory5;
    public GameObject firePosition;
    public GameObject hitItemEffect;
    public List<GameObject> bulletObjectPool;

    public Vector3 originalPosition;
    public float intervalFire;
    public int life;
    int poolSize = 32;
    
    float timeFire;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        Init();
    }

    public void Init()
    {
        LoadRocket(bulletFactory);

        timeFire = 0f;
        intervalFire = 0.5f;
        life = 3;
        originalPosition = transform.position;
    }

    public void LoadRocket(GameObject prefRocket)
    {
        if (bulletObjectPool.Count > 0)
        {
            for (int i = 0; i < bulletObjectPool.Count; i++)
            {
                Destroy(bulletObjectPool[i]);
            }
        }

        bulletObjectPool = new List<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject bullet = Instantiate(prefRocket);
            bulletObjectPool.Add(bullet);
            bullet.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance == null) return;

        timeFire += Time.deltaTime;

        // 총알 발사
        if ((Input.GetButtonDown("Fire1") || Input.GetMouseButton(0)) && timeFire > intervalFire)
        {
            

            timeFire = 0f;

            if (bulletObjectPool.Count > 0)
            {
                if (SoundControl.instance.isSoundOn) audioSource.Play();

                GameObject bullet = bulletObjectPool[0];
                bullet.SetActive(true);
                bulletObjectPool.Remove(bullet);
                bullet.transform.position = transform.position;
            }
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.gameObject.layer == LayerMask.NameToLayer("Item"))
        {
            Instantiate(hitItemEffect, collision.contacts[0].point, collision.transform.rotation);
        }
    }
}
