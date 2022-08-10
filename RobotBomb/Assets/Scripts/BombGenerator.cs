using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombGenerator : MonoBehaviour
{
    public GameObject bombPrefab;
    public float interval = 1.0f; //생성주기
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;

        if (delta > interval)
        {
            delta = 0;
            GameObject bomb = Instantiate(bombPrefab); //instantiate => 프리팻 생성해주는 것

            int x = Random.Range(-8, 9); //-8~8
            bomb.transform.position = new Vector2(x, 5); // 떨어지는 위치 랜덤 지정 
        
        }
    }
}
