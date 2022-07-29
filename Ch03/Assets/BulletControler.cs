using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControler : MonoBehaviour
{
    
    public float speed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        // bulletRd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // 마우스 왼쪽 버튼 클릭
        //if (Input.GetMouseButtonDown(0))
        //{
           // Shoot();
        //}
    }

    public void ShootForPlayer()
    {
        GetComponent<Rigidbody>().AddForce(0f, 0f, speed);
    }

    public void ShootForEnemy()
    {
        GetComponent<Rigidbody>().AddForce(0f, 0f, -speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ENEMY")
        {
            Destroy(gameObject);
        }
    }

    private void OnEnable()
    {
        Destroy(gameObject, 2f);
    }

}
