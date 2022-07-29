using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControler : MonoBehaviour
{
    float rightMax = 4f;
    float leftMax = -4f;
    float currentPostion = 0f;
    float speed = 3.0f;



    // Start is called before the first frame update
    void Start()
    {
        currentPostion = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        currentPostion += Time.deltaTime * speed;

        if (currentPostion >= rightMax)
        {
            currentPostion = rightMax ;
            speed *= -1;
        }
        else if (currentPostion <= leftMax)
        {
            currentPostion = leftMax ;
            speed *= -1;
        }

        transform.position = new Vector3(currentPostion, 1f, 4.5f);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "BULLET")
        {
            Destroy(gameObject);
        }
    }
}
