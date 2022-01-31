using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMove : MonoBehaviour
{
    float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //print("h : " + h + ", v : " + v);

        Vector3 dir = new Vector3(h, v, 0);

        //transform.Translate(dir * speed * Time.deltaTime);

        // P = P0 + vt 공식으로 변경
        transform.position += dir * speed * Time.deltaTime;
    }

}
