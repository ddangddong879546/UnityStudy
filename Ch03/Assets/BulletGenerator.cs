using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    // 프리팹 : 재활용하기 위한 오브젝트
    public GameObject bulletPrefab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // 프리팹을 이용해서 오브젝트 생성
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

            // BulletController에서 총알 발사 함수 실행
            bullet.GetComponent<BulletControler>().ShootForPlayer();

        }


    }
}
