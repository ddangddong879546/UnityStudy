using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controler : MonoBehaviour
{
    private Rigidbody playerRd;
    float speed = 10.0f;

    

    // 게임이 처음 실행될 때
    void Start()
    {
        playerRd = GetComponent<Rigidbody>(); // 제네릭
    }

    // 게임이 실행될 때 각 프레임 별로 호출
    void Update()
    {
        //print("Update!");

        if (Input.GetKey(KeyCode.D) == true)
        {
            // Vector3 타입은 벡터의 방향과 속도를 가지고 오브젝트를 이동할 수 있다
            // deltaTime은 컴퓨터의 성능에 따라 프레임 속도를 일정하도록 프레임 시간 간격을 동기화 시키는 값


            playerRd.AddForce(speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.A) == true)
        {
            playerRd.AddForce(-speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.W) == true)
        {
            playerRd.AddForce(0f, 0f, speed);
        }

        if (Input.GetKey(KeyCode.S) == true)
        {
            playerRd.AddForce(0f, 0f, -speed);
        }

        if (Input.GetKey(KeyCode.Space) == true)
        {
            playerRd.AddForce(0f, speed, 0f);
        }
    }  
}
