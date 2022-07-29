using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletGenerator : MonoBehaviour
{
    // 프리팹 : 재활용하기 위한 오브젝트
    public GameObject bulletPrefab;

    private float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > 0.5)
        {
            // 프리팹을 이용해서 오브젝트 생성
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

            // BulletController에서 총알 발사 함수 실행
            bullet.GetComponent<BulletControler>().ShootForEnemy();

            time = 0f;

        }
    }
}
