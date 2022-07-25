using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controler : MonoBehaviour
{
    float speed = 10.0f;

    // ������ ó�� ����� ��
    void Start()
    {
        print("Start!");
    }

    // ������ ����� �� �� ������ ���� ȣ��
    void Update()
    {
        //print("Update!");

        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            // Vector3 Ÿ���� ������ ����� �ӵ��� ������ ������Ʈ�� �̵��� �� �ִ�
            // deltaTime�� ��ǻ���� ���ɿ� ���� ������ �ӵ��� �����ϵ��� ������ �ð� ������ ����ȭ ��Ű�� ��
            
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
    }
}
