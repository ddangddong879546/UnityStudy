using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    private Rigidbody playerRD;
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerRD = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.Translate(Vector3.left * speed * Time.deltaTime);
            playerRD.AddForce(-speed,0,0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //transform.Translate(Vector3.right * speed * Time.deltaTime);
            playerRD.AddForce(speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            //transform.Translate(Vector3.forward * speed * Time.deltaTime);
            playerRD.AddForce(0, 0, speed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            //transform.Translate(Vector3.back * speed * Time.deltaTime);
            playerRD.AddForce(0, 0, -speed);
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Player 충돌 Enter : " + collision.gameObject.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        print("Player 충돌 Exit : " + collision.gameObject.name);
    }
}
