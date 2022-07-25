using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controler : MonoBehaviour
{
    private Rigidbody playerRd;
    float speed = 10.0f;

    

    // ������ ó�� ����� ��
    void Start()
    {
        playerRd = GetComponent<Rigidbody>(); // ���׸�
    }

    // ������ ����� �� �� ������ ���� ȣ��
    void Update()
    {
        //print("Update!");

        if (Input.GetKey(KeyCode.D) == true)
        {
            // Vector3 Ÿ���� ������ ����� �ӵ��� ������ ������Ʈ�� �̵��� �� �ִ�
            // deltaTime�� ��ǻ���� ���ɿ� ���� ������ �ӵ��� �����ϵ��� ������ �ð� ������ ����ȭ ��Ű�� ��


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
