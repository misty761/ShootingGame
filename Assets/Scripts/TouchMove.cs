using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMove : MonoBehaviour
{
    Rigidbody myRigidbody;
    TouchZone touchZone;

    public float speed = 5f;

    // Start is called before the first frame update 
    void Start() 
    {
        myRigidbody = GetComponent<Rigidbody>();
        touchZone = FindObjectOfType<TouchZone>();
    } 

    // Update is called once per frame 
    void Update() 
    {
        if (GameManager.instance == null) return;
        if (GameManager.instance.isGameOver) return;

        if (Input.touchCount >= 1 && touchZone.isTouched)
        {
            transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.touches[0].position.x, Input.touches[0].position.y, 10f));
        }
        else
        {
            myRigidbody.velocity = Vector3.zero;
        }


    } 
}

